namespace Hotel
{
    partial class UserControl1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_1 = new System.Windows.Forms.Label();
            this.btn_1 = new System.Windows.Forms.Button();
            this.cmb_2 = new System.Windows.Forms.ComboBox();
            this.cmb_1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(47, 20);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(43, 13);
            this.lbl_1.TabIndex = 0;
            this.lbl_1.Text = "HOTEL";
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(19, 75);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(100, 45);
            this.btn_1.TabIndex = 1;
            this.btn_1.Text = "button1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_2
            // 
            this.cmb_2.FormattingEnabled = true;
            this.cmb_2.Items.AddRange(new object[] {
            "Base",
            "Media",
            "Alta"});
            this.cmb_2.Location = new System.Drawing.Point(19, 36);
            this.cmb_2.Name = "cmb_2";
            this.cmb_2.Size = new System.Drawing.Size(121, 21);
            this.cmb_2.TabIndex = 2;
            // 
            // cmb_1
            // 
            this.cmb_1.FormattingEnabled = true;
            this.cmb_1.Items.AddRange(new object[] {
            "Bassa",
            "Media",
            "Alta"});
            this.cmb_1.Location = new System.Drawing.Point(196, 36);
            this.cmb_1.Name = "cmb_1";
            this.cmb_1.Size = new System.Drawing.Size(121, 21);
            this.cmb_1.TabIndex = 3;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_1);
            this.Controls.Add(this.cmb_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.lbl_1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.ComboBox cmb_2;
        private System.Windows.Forms.ComboBox cmb_1;
    }
}
