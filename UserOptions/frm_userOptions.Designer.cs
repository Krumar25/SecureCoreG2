
namespace UserOptions
{
    partial class frm_userOptions
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
            this.swTextBox3 = new CustomControls.SWTextBox();
            this.swTextBox4 = new CustomControls.SWTextBox();
            this.swTextBox5 = new CustomControls.SWTextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblform = new System.Windows.Forms.Label();
            this.lblDLL_name = new System.Windows.Forms.Label();
            this.lblicon_img = new System.Windows.Forms.Label();
            this.lblAccessLevel = new System.Windows.Forms.Label();
            this.cboxAccessLevel = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlManteniment1
            // 
            this.controlManteniment1.Location = new System.Drawing.Point(234, 64);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboxAccessLevel);
            this.panel1.Controls.Add(this.lblAccessLevel);
            this.panel1.Controls.Add(this.lblicon_img);
            this.panel1.Controls.Add(this.lblDLL_name);
            this.panel1.Controls.Add(this.lblform);
            this.panel1.Controls.Add(this.lblClass);
            this.panel1.Controls.Add(this.swTextBox5);
            this.panel1.Controls.Add(this.swTextBox4);
            this.panel1.Controls.Add(this.swTextBox3);
            this.panel1.Controls.Add(this.swTextBox1);
            this.panel1.Size = new System.Drawing.Size(1250, 929);
            this.panel1.Controls.SetChildIndex(this.controlManteniment1, 0);
            this.panel1.Controls.SetChildIndex(this.swTextBox1, 0);
            this.panel1.Controls.SetChildIndex(this.swTextBox3, 0);
            this.panel1.Controls.SetChildIndex(this.swTextBox4, 0);
            this.panel1.Controls.SetChildIndex(this.swTextBox5, 0);
            this.panel1.Controls.SetChildIndex(this.lblClass, 0);
            this.panel1.Controls.SetChildIndex(this.lblform, 0);
            this.panel1.Controls.SetChildIndex(this.lblDLL_name, 0);
            this.panel1.Controls.SetChildIndex(this.lblicon_img, 0);
            this.panel1.Controls.SetChildIndex(this.lblAccessLevel, 0);
            this.panel1.Controls.SetChildIndex(this.cboxAccessLevel, 0);
            // 
            // swTextBox1
            // 
            this.swTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swTextBox1.CampBBDD = "class";
            this.swTextBox1.DadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTextBox1.EsForana = false;
            this.swTextBox1.EsNulable = false;
            this.swTextBox1.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTextBox1.Location = new System.Drawing.Point(525, 208);
            this.swTextBox1.Name = "swTextBox1";
            this.swTextBox1.Size = new System.Drawing.Size(450, 33);
            this.swTextBox1.TabIndex = 4;
            // 
            // swTextBox3
            // 
            this.swTextBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swTextBox3.CampBBDD = "form";
            this.swTextBox3.DadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTextBox3.EsForana = false;
            this.swTextBox3.EsNulable = false;
            this.swTextBox3.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTextBox3.Location = new System.Drawing.Point(525, 364);
            this.swTextBox3.Name = "swTextBox3";
            this.swTextBox3.Size = new System.Drawing.Size(450, 33);
            this.swTextBox3.TabIndex = 6;
            // 
            // swTextBox4
            // 
            this.swTextBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swTextBox4.CampBBDD = "DLL_name";
            this.swTextBox4.DadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTextBox4.EsForana = false;
            this.swTextBox4.EsNulable = false;
            this.swTextBox4.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTextBox4.Location = new System.Drawing.Point(525, 286);
            this.swTextBox4.Name = "swTextBox4";
            this.swTextBox4.Size = new System.Drawing.Size(450, 33);
            this.swTextBox4.TabIndex = 7;
            // 
            // swTextBox5
            // 
            this.swTextBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swTextBox5.CampBBDD = "icon_img";
            this.swTextBox5.DadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTextBox5.EsForana = false;
            this.swTextBox5.EsNulable = false;
            this.swTextBox5.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTextBox5.Location = new System.Drawing.Point(525, 442);
            this.swTextBox5.Name = "swTextBox5";
            this.swTextBox5.Size = new System.Drawing.Size(450, 33);
            this.swTextBox5.TabIndex = 8;
            // 
            // lblClass
            // 
            this.lblClass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblClass.AutoSize = true;
            this.lblClass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblClass.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.ForeColor = System.Drawing.Color.Yellow;
            this.lblClass.Location = new System.Drawing.Point(415, 211);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(73, 25);
            this.lblClass.TabIndex = 10;
            this.lblClass.Text = "Clase";
            // 
            // lblform
            // 
            this.lblform.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblform.AutoSize = true;
            this.lblform.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblform.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblform.ForeColor = System.Drawing.Color.Yellow;
            this.lblform.Location = new System.Drawing.Point(419, 289);
            this.lblform.Name = "lblform";
            this.lblform.Size = new System.Drawing.Size(69, 25);
            this.lblform.TabIndex = 11;
            this.lblform.Text = "Form";
            // 
            // lblDLL_name
            // 
            this.lblDLL_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDLL_name.AutoSize = true;
            this.lblDLL_name.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDLL_name.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDLL_name.ForeColor = System.Drawing.Color.Yellow;
            this.lblDLL_name.Location = new System.Drawing.Point(339, 367);
            this.lblDLL_name.Name = "lblDLL_name";
            this.lblDLL_name.Size = new System.Drawing.Size(149, 25);
            this.lblDLL_name.TabIndex = 12;
            this.lblDLL_name.Text = "Nombre DLL";
            // 
            // lblicon_img
            // 
            this.lblicon_img.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblicon_img.AutoSize = true;
            this.lblicon_img.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblicon_img.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblicon_img.ForeColor = System.Drawing.Color.Yellow;
            this.lblicon_img.Location = new System.Drawing.Point(323, 445);
            this.lblicon_img.Name = "lblicon_img";
            this.lblicon_img.Size = new System.Drawing.Size(165, 25);
            this.lblicon_img.TabIndex = 13;
            this.lblicon_img.Text = "Imagen Icono";
            // 
            // lblAccessLevel
            // 
            this.lblAccessLevel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAccessLevel.AutoSize = true;
            this.lblAccessLevel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAccessLevel.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessLevel.ForeColor = System.Drawing.Color.Yellow;
            this.lblAccessLevel.Location = new System.Drawing.Point(82, 211);
            this.lblAccessLevel.Name = "lblAccessLevel";
            this.lblAccessLevel.Size = new System.Drawing.Size(154, 25);
            this.lblAccessLevel.TabIndex = 14;
            this.lblAccessLevel.Text = "Access Level";
            // 
            // cboxAccessLevel
            // 
            this.cboxAccessLevel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboxAccessLevel.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxAccessLevel.FormattingEnabled = true;
            this.cboxAccessLevel.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.cboxAccessLevel.Location = new System.Drawing.Point(254, 208);
            this.cboxAccessLevel.Name = "cboxAccessLevel";
            this.cboxAccessLevel.Size = new System.Drawing.Size(88, 33);
            this.cboxAccessLevel.TabIndex = 15;
            this.cboxAccessLevel.Tag = "AccessLevel";
            // 
            // frm_userOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 929);
            this.Name = "frm_userOptions";
            this.Text = "frm_userOptions";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.SWTextBox swTextBox5;
        private CustomControls.SWTextBox swTextBox4;
        private CustomControls.SWTextBox swTextBox3;
        private CustomControls.SWTextBox swTextBox1;
        private System.Windows.Forms.Label lblAccessLevel;
        private System.Windows.Forms.Label lblicon_img;
        private System.Windows.Forms.Label lblDLL_name;
        private System.Windows.Forms.Label lblform;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cboxAccessLevel;
    }
}