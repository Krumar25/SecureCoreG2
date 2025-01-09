using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Users
{
    
    public partial class Tarjeta : Form
    {
        private string id;
        private ReportDocument cryRpt;
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public Tarjeta()
        {
            InitializeComponent();

        }

        private void Tarjeta_Load(object sender, EventArgs e)
        {
            CargarCrystalReports();
        }

        private void SetCredencialesCrystal()
        {
            // Asigna las credenciales
            string servidor = "sqlserver.S2AM.sdslab.cat";
            string baseDeDatos = "SecureCoreG2";
            string usuario = "G2";
            string contraseña = "12345G2aA2425.";

            // Configurar las credenciales para todas las tablas del reporte
            foreach (Table table in cryRpt.Database.Tables)
            {
                TableLogOnInfo tableLogOnInfo = table.LogOnInfo;
                tableLogOnInfo.ConnectionInfo.ServerName = servidor;
                tableLogOnInfo.ConnectionInfo.DatabaseName = baseDeDatos;
                tableLogOnInfo.ConnectionInfo.UserID = usuario;
                tableLogOnInfo.ConnectionInfo.Password = contraseña;
                table.ApplyLogOnInfo(tableLogOnInfo);
            }

            // Si tienes subreportes, configúralos también
            foreach (Section section in cryRpt.ReportDefinition.Sections)
            {
                foreach (ReportObject reportObject in section.ReportObjects)
                {
                    if (reportObject.Kind == ReportObjectKind.SubreportObject)
                    {
                        SubreportObject subreportObject = (SubreportObject)reportObject;
                        ReportDocument subreportDocument = subreportObject.OpenSubreport(subreportObject.SubreportName);

                        foreach (Table table in subreportDocument.Database.Tables)
                        {
                            TableLogOnInfo tableLogOnInfo = table.LogOnInfo;
                            tableLogOnInfo.ConnectionInfo.ServerName = servidor;
                            tableLogOnInfo.ConnectionInfo.DatabaseName = baseDeDatos;
                            tableLogOnInfo.ConnectionInfo.UserID = usuario;
                            tableLogOnInfo.ConnectionInfo.Password = contraseña;
                            table.ApplyLogOnInfo(tableLogOnInfo);
                        }
                    }
                }
            }

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }

        private void CargarCrystalReports()
        {
            cryRpt = new ReportDocument();
            cryRpt.Load("TarjetaUsuari.rpt");

            SetCredencialesCrystal();

            cryRpt.RecordSelectionFormula = "{Users.idUser} = " + Convert.ToInt32(id);

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }
    }
}
