
namespace UserCategories
{
    partial class frm_userCategories
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
            this.lbl_code = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.swTextBox2 = new CustomControls.SWTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.swTextBox4 = new CustomControls.SWTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlManteniment1
            // 
            this.controlManteniment1.Location = new System.Drawing.Point(161, 71);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.swTextBox4);
            this.panel1.Controls.Add(this.swTextBox2);
            this.panel1.Controls.Add(this.lbl_desc);
            this.panel1.Controls.Add(this.lbl_code);
            this.panel1.Controls.Add(this.swTextBox1);
            this.panel1.Size = new System.Drawing.Size(657, 450);
            this.panel1.Controls.SetChildIndex(this.controlManteniment1, 0);
            this.panel1.Controls.SetChildIndex(this.swTextBox1, 0);
            this.panel1.Controls.SetChildIndex(this.lbl_code, 0);
            this.panel1.Controls.SetChildIndex(this.lbl_desc, 0);
            this.panel1.Controls.SetChildIndex(this.swTextBox2, 0);
            this.panel1.Controls.SetChildIndex(this.swTextBox4, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            // 
            // swTextBox1
            // 
            this.swTextBox1.CampBBDD = null;
            this.swTextBox1.DadaPermesa = CustomControls.SWTextBox.TipusDada.Numero;
            this.swTextBox1.EsForana = false;
            this.swTextBox1.EsNulable = false;
            this.swTextBox1.Location = new System.Drawing.Point(185, 264);
            this.swTextBox1.Name = "swTextBox1";
            this.swTextBox1.Size = new System.Drawing.Size(71, 20);
            this.swTextBox1.TabIndex = 4;
            this.swTextBox1.TextChanged += new System.EventHandler(this.swTextBox1_TextChanged);
            // 
            // lbl_code
            // 
            this.lbl_code.AutoSize = true;
            this.lbl_code.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_code.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_code.Location = new System.Drawing.Point(116, 264);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(63, 17);
            this.lbl_code.TabIndex = 5;
            this.lbl_code.Text = "Código";
            this.lbl_code.Click += new System.EventHandler(this.lbl_code_Click);
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desc.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_desc.Location = new System.Drawing.Point(271, 264);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(98, 17);
            this.lbl_desc.TabIndex = 6;
            this.lbl_desc.Text = "Descripción";
            this.lbl_desc.Click += new System.EventHandler(this.lbl_desc_Click);
            // 
            // swTextBox2
            // 
            this.swTextBox2.CampBBDD = null;
            this.swTextBox2.DadaPermesa = CustomControls.SWTextBox.TipusDada.Numero;
            this.swTextBox2.EsForana = false;
            this.swTextBox2.EsNulable = false;
            this.swTextBox2.Location = new System.Drawing.Point(375, 264);
            this.swTextBox2.Name = "swTextBox2";
            this.swTextBox2.Size = new System.Drawing.Size(199, 20);
            this.swTextBox2.TabIndex = 7;
            this.swTextBox2.TextChanged += new System.EventHandler(this.swTextBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(73, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Access Level";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // swTextBox4
            // 
            this.swTextBox4.CampBBDD = null;
            this.swTextBox4.DadaPermesa = CustomControls.SWTextBox.TipusDada.Numero;
            this.swTextBox4.EsForana = false;
            this.swTextBox4.EsNulable = false;
            this.swTextBox4.Location = new System.Drawing.Point(185, 222);
            this.swTextBox4.Name = "swTextBox4";
            this.swTextBox4.Size = new System.Drawing.Size(71, 20);
            this.swTextBox4.TabIndex = 8;
            this.swTextBox4.TextChanged += new System.EventHandler(this.swTextBox4_TextChanged);
            // 
            // frm_userCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frm_userCategories";
            this.Text = "frm_userCategories";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.SWTextBox swTextBox1;
        private System.Windows.Forms.Label lbl_code;
        private System.Windows.Forms.Label label2;
        private CustomControls.SWTextBox swTextBox4;
        private CustomControls.SWTextBox swTextBox2;
        private System.Windows.Forms.Label lbl_desc;
    }
}