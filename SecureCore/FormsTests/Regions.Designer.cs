
namespace FormsTests
{
    partial class Regions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.swTextBox1 = new CustomControls.SWTextBox();
            this.swTextBox2 = new CustomControls.SWTextBox();
            this.swTextBox3 = new CustomControls.SWTextBox();
            this.swTextBox4 = new CustomControls.SWTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlManteniment1
            // 
            this.controlManteniment1.Location = new System.Drawing.Point(370, 74);
            this.controlManteniment1.NomForm = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.swTextBox4);
            this.panel1.Controls.Add(this.swTextBox3);
            this.panel1.Controls.Add(this.swTextBox2);
            this.panel1.Controls.Add(this.swTextBox1);
            this.panel1.Size = new System.Drawing.Size(1135, 1038);
            this.panel1.Controls.SetChildIndex(this.controlManteniment1, 0);
            this.panel1.Controls.SetChildIndex(this.swTextBox1, 0);
            this.panel1.Controls.SetChildIndex(this.swTextBox2, 0);
            this.panel1.Controls.SetChildIndex(this.swTextBox3, 0);
            this.panel1.Controls.SetChildIndex(this.swTextBox4, 0);
            // 
            // swTextBox1
            // 
            this.swTextBox1.CampBBDD = "CodeRegion";
            this.swTextBox1.DadaPermesa = CustomControls.SWTextBox.TipusDada.Codi;
            this.swTextBox1.EsForana = false;
            this.swTextBox1.EsNulable = false;
            this.swTextBox1.Location = new System.Drawing.Point(428, 315);
            this.swTextBox1.Name = "swTextBox1";
            this.swTextBox1.Size = new System.Drawing.Size(100, 22);
            this.swTextBox1.TabIndex = 5;
            // 
            // swTextBox2
            // 
            this.swTextBox2.CampBBDD = "DescRegion";
            this.swTextBox2.DadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTextBox2.EsForana = false;
            this.swTextBox2.EsNulable = false;
            this.swTextBox2.Location = new System.Drawing.Point(428, 388);
            this.swTextBox2.Name = "swTextBox2";
            this.swTextBox2.Size = new System.Drawing.Size(100, 22);
            this.swTextBox2.TabIndex = 6;
            // 
            // swTextBox3
            // 
            this.swTextBox3.CampBBDD = "Remarks";
            this.swTextBox3.DadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTextBox3.EsForana = false;
            this.swTextBox3.EsNulable = false;
            this.swTextBox3.Location = new System.Drawing.Point(428, 458);
            this.swTextBox3.Name = "swTextBox3";
            this.swTextBox3.Size = new System.Drawing.Size(100, 22);
            this.swTextBox3.TabIndex = 7;
            // 
            // swTextBox4
            // 
            this.swTextBox4.CampBBDD = "idRegion";
            this.swTextBox4.DadaPermesa = CustomControls.SWTextBox.TipusDada.Numero;
            this.swTextBox4.EsForana = false;
            this.swTextBox4.EsNulable = false;
            this.swTextBox4.Location = new System.Drawing.Point(428, 252);
            this.swTextBox4.Name = "swTextBox4";
            this.swTextBox4.Size = new System.Drawing.Size(100, 22);
            this.swTextBox4.TabIndex = 8;
            // 
            // Regions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 1038);
            this.Name = "Regions";
            this.Text = "Regions";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.SWTextBox swTextBox1;
        private CustomControls.SWTextBox swTextBox4;
        private CustomControls.SWTextBox swTextBox3;
        private CustomControls.SWTextBox swTextBox2;
    }
}