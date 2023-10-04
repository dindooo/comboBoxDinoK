namespace comboBoxDinoK
{
    partial class Form1
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
            this.cmbOdabir = new System.Windows.Forms.ComboBox();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbOdabir
            // 
            this.cmbOdabir.FormattingEnabled = true;
            this.cmbOdabir.Items.AddRange(new object[] {
            "IT menadžment",
            "Aplikativno programiranje",
            "Internet programiranje",
            "Informacioni sistemi"});
            this.cmbOdabir.Location = new System.Drawing.Point(143, 100);
            this.cmbOdabir.Name = "cmbOdabir";
            this.cmbOdabir.Size = new System.Drawing.Size(121, 21);
            this.cmbOdabir.TabIndex = 0;
            this.cmbOdabir.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(336, 100);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(171, 131);
            this.txtIspis.TabIndex = 1;
            this.txtIspis.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.cmbOdabir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOdabir;
        private System.Windows.Forms.TextBox txtIspis;
    }
}

