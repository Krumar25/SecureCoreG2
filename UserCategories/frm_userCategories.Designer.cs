
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
            this.cboxAccessLevel = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlManteniment1
            // 
            this.controlManteniment1.Location = new System.Drawing.Point(452, 202);
            this.controlManteniment1.Margin = new System.Windows.Forms.Padding(14, 18, 14, 18);
            this.controlManteniment1.Size = new System.Drawing.Size(566, 106);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboxAccessLevel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.swTextBox2);
            this.panel1.Controls.Add(this.lbl_desc);
            this.panel1.Controls.Add(this.lbl_code);
            this.panel1.Controls.Add(this.swTextBox1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Size = new System.Drawing.Size(1552, 1298);
            this.panel1.Controls.SetChildIndex(this.controlManteniment1, 0);
            this.panel1.Controls.SetChildIndex(this.swTextBox1, 0);
            this.panel1.Controls.SetChildIndex(this.lbl_code, 0);
            this.panel1.Controls.SetChildIndex(this.lbl_desc, 0);
            this.panel1.Controls.SetChildIndex(this.swTextBox2, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.cboxAccessLevel, 0);
            // 
            // swTextBox1
            // 
            this.swTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swTextBox1.CampBBDD = "CodeCategory";
            this.swTextBox1.DadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTextBox1.EsForana = false;
            this.swTextBox1.EsNulable = false;
            this.swTextBox1.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.swTextBox1.Location = new System.Drawing.Point(487, 615);
            this.swTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTextBox1.Name = "swTextBox1";
            this.swTextBox1.Size = new System.Drawing.Size(104, 33);
            this.swTextBox1.TabIndex = 4;
            // 
            // lbl_code
            // 
            this.lbl_code.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_code.AutoSize = true;
            this.lbl_code.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_code.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_code.Location = new System.Drawing.Point(384, 619);
            this.lbl_code.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(95, 26);
            this.lbl_code.TabIndex = 5;
            this.lbl_code.Text = "Código";
            // 
            // lbl_desc
            // 
            this.lbl_desc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desc.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_desc.Location = new System.Drawing.Point(659, 621);
            this.lbl_desc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(149, 26);
            this.lbl_desc.TabIndex = 6;
            this.lbl_desc.Text = "Descripción";
            // 
            // swTextBox2
            // 
            this.swTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swTextBox2.CampBBDD = "DescCategory";
            this.swTextBox2.DadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTextBox2.EsForana = false;
            this.swTextBox2.EsNulable = false;
            this.swTextBox2.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.swTextBox2.Location = new System.Drawing.Point(815, 617);
            this.swTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTextBox2.Name = "swTextBox2";
            this.swTextBox2.Size = new System.Drawing.Size(296, 33);
            this.swTextBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(317, 519);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Access Level";
            // 
            // cboxAccessLevel
            // 
            this.cboxAccessLevel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboxAccessLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cboxAccessLevel.Location = new System.Drawing.Point(485, 512);
            this.cboxAccessLevel.Name = "cboxAccessLevel";
            this.cboxAccessLevel.Size = new System.Drawing.Size(104, 33);
            this.cboxAccessLevel.TabIndex = 16;
            this.cboxAccessLevel.Tag = "AccessLevel";
            // 
            // frm_userCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1874, 1298);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "frm_userCategories";
            this.Text = "frm_userCategories";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextBox swTextBox1;
        private System.Windows.Forms.Label lbl_code;
        private System.Windows.Forms.Label label2;
        private CustomControls.SWTextBox swTextBox2;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.ComboBox cboxAccessLevel;
    }
}