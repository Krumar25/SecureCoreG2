
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
            this.controlManteniment1.Location = new System.Drawing.Point(247, 96);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.swTextBox4);
            this.panel1.Controls.Add(this.swTextBox2);
            this.panel1.Controls.Add(this.lbl_desc);
            this.panel1.Controls.Add(this.lbl_code);
            this.panel1.Controls.Add(this.swTextBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.None;
            this.panel1.Size = new System.Drawing.Size(777, 483);
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
            this.swTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swTextBox1.CampBBDD = "CodeCategory";
            this.swTextBox1.DadaPermesa = CustomControls.SWTextBox.TipusDada.Numero;
            this.swTextBox1.EsForana = false;
            this.swTextBox1.EsNulable = false;
            this.swTextBox1.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTextBox1.Location = new System.Drawing.Point(286, 289);
            this.swTextBox1.Name = "swTextBox1";
            this.swTextBox1.Size = new System.Drawing.Size(71, 25);
            this.swTextBox1.TabIndex = 4;
            // 
            // lbl_code
            // 
            this.lbl_code.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_code.AutoSize = true;
            this.lbl_code.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_code.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_code.Location = new System.Drawing.Point(217, 292);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(63, 17);
            this.lbl_code.TabIndex = 5;
            this.lbl_code.Text = "Código";
            // 
            // lbl_desc
            // 
            this.lbl_desc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desc.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_desc.Location = new System.Drawing.Point(372, 292);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(98, 17);
            this.lbl_desc.TabIndex = 6;
            this.lbl_desc.Text = "Descripción";
            // 
            // swTextBox2
            // 
            this.swTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swTextBox2.CampBBDD = "DescCategory";
            this.swTextBox2.DadaPermesa = CustomControls.SWTextBox.TipusDada.Numero;
            this.swTextBox2.EsForana = false;
            this.swTextBox2.EsNulable = false;
            this.swTextBox2.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTextBox2.Location = new System.Drawing.Point(476, 289);
            this.swTextBox2.Name = "swTextBox2";
            this.swTextBox2.Size = new System.Drawing.Size(199, 25);
            this.swTextBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(174, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Access Level";
            // 
            // swTextBox4
            // 
            this.swTextBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swTextBox4.CampBBDD = "AccessLevel";
            this.swTextBox4.DadaPermesa = CustomControls.SWTextBox.TipusDada.Numero;
            this.swTextBox4.EsForana = false;
            this.swTextBox4.EsNulable = false;
            this.swTextBox4.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTextBox4.Location = new System.Drawing.Point(286, 247);
            this.swTextBox4.Name = "swTextBox4";
            this.swTextBox4.Size = new System.Drawing.Size(71, 25);
            this.swTextBox4.TabIndex = 8;
            // 
            // frm_userCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 485);
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