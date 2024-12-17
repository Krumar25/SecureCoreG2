using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Dades
{ public class AccesADades
    {
        private SqlConnection conn;

        private void Connectar()
        {
            string cnx;
            ConnectionStringSettings conf = ConfigurationManager.ConnectionStrings["Dades"];

            if (conf != null)
            {
                cnx = conf.ConnectionString;
            }
            else
            {
                throw new InvalidOperationException("No hi ha cap connection string");
            }

            conn = new SqlConnection(cnx);
        }
        public DataSet PortarTaula(string nomTaula)
        {
            SqlDataAdapter adapter;
            DataSet dts = new DataSet();

            string query = $"SELECT * FROM {nomTaula}";
            adapter = new SqlDataAdapter(query, conn);
            conn.Open();

            adapter.Fill(dts, nomTaula);

            conn.Close();

            return dts;
        }
        
        public DataSet PortarPerConsulta(string query)
        {
            string nomTaula = "DadesAlumnes";
            SqlDataAdapter adapter;
            DataSet dts = new DataSet();

            adapter = new SqlDataAdapter(query, conn);
            conn.Open();

            adapter.Fill(dts, nomTaula);

            conn.Close();

            return dts;
        } 
        public DataSet PortarPerConsulta(string query, string nomTaula)
        {
            Connectar();

            SqlDataAdapter adapter;
            DataSet dts = new DataSet();

            adapter = new SqlDataAdapter(query, conn);
            conn.Open();

            adapter.Fill(dts, nomTaula);

            conn.Close();

            return dts;
        } 
        public void Actualitzar(string query, DataSet dts)
        {
            conn.Open();

            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder cmdBuilder;
            cmdBuilder = new SqlCommandBuilder(adapter);

            if (dts.HasChanges())
            {
                int result = adapter.Update(dts.Tables[0]);
            }
            conn.Close();
        }

        public DataSet GenerarConsultaCerca(string query, Dictionary<string, string> parameters)
        {
            DataSet dts = new DataSet();
            SqlDataAdapter adapter;

            // Configuramos la conexión
            Connectar();

            SqlCommand command = new SqlCommand(query, conn);

            // Agregamos los parámetros desde el diccionario
            foreach (var param in parameters)
            {
                command.Parameters.AddWithValue(param.Key, param.Value);
            }

            adapter = new SqlDataAdapter(command);
            conn.Open();

            // Rellenamos de datos el DataSet
            adapter.Fill(dts, "Nom taula");

            conn.Close();

            return dts;
        }
        public void Executa(string query, Dictionary<string, string> parameters)
        {
            Connectar();

            conn.Open();
            SqlCommand cmd;
            cmd = new SqlCommand(query, conn);
            foreach (var param in parameters)
            {
                cmd.Parameters.AddWithValue(param.Key, param.Value);
            }
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            conn.Close();
        }
    }
}
