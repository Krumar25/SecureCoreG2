
namespace RangUsuari
{
    partial class frmRangUsuari
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
            this.lblCodiR = new System.Windows.Forms.Label();
            this.lblDescR = new System.Windows.Forms.Label();
            this.swTextBox1 = new CustomControls.SWTextBox();
            this.swTextBox2 = new CustomControls.SWTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlManteniment1
            // 
            this.controlManteniment1.Location = new System.Drawing.Point(538, 180);
            this.controlManteniment1.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.controlManteniment1.NomClase = "Rang Usuari";
            this.controlManteniment1.NomForm = "frmRangUsuari";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.swTextBox2);
            this.panel1.Controls.Add(this.swTextBox1);
            this.panel1.Controls.Add(this.lblDescR);
            this.panel1.Controls.Add(this.lblCodiR);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Size = new System.Drawing.Size(1497, 1298);
            this.panel1.Controls.SetChildIndex(this.controlManteniment1, 0);
            this.panel1.Controls.SetChildIndex(this.lblCodiR, 0);
            this.panel1.Controls.SetChildIndex(this.lblDescR, 0);
            this.panel1.Controls.SetChildIndex(this.swTextBox1, 0);
            this.panel1.Controls.SetChildIndex(this.swTextBox2, 0);
            // 
            // lblCodiR
            // 
            this.lblCodiR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCodiR.AutoSize = true;
            this.lblCodiR.BackColor = System.Drawing.Color.Transparent;
            this.lblCodiR.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodiR.ForeColor = System.Drawing.Color.Yellow;
            this.lblCodiR.Location = new System.Drawing.Point(507, 494);
            this.lblCodiR.Name = "lblCodiR";
            this.lblCodiR.Size = new System.Drawing.Size(98, 27);
            this.lblCodiR.TabIndex = 4;
            this.lblCodiR.Text = "Código";
            // 
            // lblDescR
            // 
            this.lblDescR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescR.AutoSize = true;
            this.lblDescR.BackColor = System.Drawing.Color.Transparent;
            this.lblDescR.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescR.ForeColor = System.Drawing.Color.Yellow;
            this.lblDescR.Location = new System.Drawing.Point(464, 597);
            this.lblDescR.Name = "lblDescR";
            this.lblDescR.Size = new System.Drawing.Size(155, 27);
            this.lblDescR.TabIndex = 5;
            this.lblDescR.Text = "Descripción";
            // 
            // swTextBox1
            // 
            this.swTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swTextBox1.CampBBDD = "CodeRank";
            this.swTextBox1.DadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTextBox1.EsForana = false;
            this.swTextBox1.EsNulable = false;
            this.swTextBox1.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.swTextBox1.Location = new System.Drawing.Point(661, 494);
            this.swTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.swTextBox1.Name = "swTextBox1";
            this.swTextBox1.Size = new System.Drawing.Size(275, 33);
            this.swTextBox1.TabIndex = 6;
            // 
            // swTextBox2
            // 
            this.swTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swTextBox2.CampBBDD = "DescRank";
            this.swTextBox2.DadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTextBox2.EsForana = false;
            this.swTextBox2.EsNulable = false;
            this.swTextBox2.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.swTextBox2.Location = new System.Drawing.Point(661, 597);
            this.swTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.swTextBox2.Name = "swTextBox2";
            this.swTextBox2.Size = new System.Drawing.Size(275, 33);
            this.swTextBox2.TabIndex = 7;
            // 
            // frmRangUsuari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1819, 1298);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmRangUsuari";
            this.Text = "frmRangUsuari";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodiR;
        private System.Windows.Forms.Label lblDescR;
        private CustomControls.SWTextBox swTextBox2;
        private CustomControls.SWTextBox swTextBox1;
    }
}