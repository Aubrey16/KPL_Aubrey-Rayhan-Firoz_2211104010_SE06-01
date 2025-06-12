namespace modul12_NIM
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
            txtAngka1 = new TextBox();
            txtAngka2 = new TextBox();
            btnHitung = new Button();
            lblHasil = new Label();
            SuspendLayout();
            // 
            // txtAngka1
            // 
            txtAngka1.Location = new Point(30, 30);
            txtAngka1.Name = "txtAngka1";
            txtAngka1.Size = new Size(100, 27);
            txtAngka1.TabIndex = 0;
            // 
            // txtAngka2
            // 
            txtAngka2.Location = new Point(30, 60);
            txtAngka2.Name = "txtAngka2";
            txtAngka2.Size = new Size(100, 27);
            txtAngka2.TabIndex = 1;
            // 
            // btnHitung
            // 
            btnHitung.Location = new Point(30, 100);
            btnHitung.Name = "btnHitung";
            btnHitung.Size = new Size(100, 23);
            btnHitung.TabIndex = 2;
            btnHitung.Text = "Hitung Pangkat";
            btnHitung.UseVisualStyleBackColor = true;
            btnHitung.Click += btnHitung_Click;
            // 
            // lblHasil
            // 
            lblHasil.AutoSize = true;
            lblHasil.Location = new Point(30, 140);
            lblHasil.Name = "lblHasil";
            lblHasil.Size = new Size(55, 20);
            lblHasil.TabIndex = 3;
            lblHasil.Text = "Hasil: -";
            // 
            // Form1
            // 
            ClientSize = new Size(284, 191);
            Controls.Add(lblHasil);
            Controls.Add(btnHitung);
            Controls.Add(txtAngka2);
            Controls.Add(txtAngka1);
            Name = "Form1";
            Text = "modul12_NIM - Cari Nilai Pangkat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtAngka1;
        private System.Windows.Forms.TextBox txtAngka2;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Label lblHasil;
    }
}
