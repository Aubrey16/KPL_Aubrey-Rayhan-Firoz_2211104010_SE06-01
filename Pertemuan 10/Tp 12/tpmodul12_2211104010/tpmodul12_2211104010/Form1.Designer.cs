namespace tpmodul12_2211104010
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelHasil = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(309, 182);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(94, 29);
            this.buttonCheck.TabIndex = 0;
            this.buttonCheck.Text = "Cek";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // labelHasil
            // 
            this.labelHasil.AutoSize = true;
            this.labelHasil.Location = new System.Drawing.Point(309, 225);
            this.labelHasil.Name = "labelHasil";
            this.labelHasil.Size = new System.Drawing.Size(0, 20);
            this.labelHasil.TabIndex = 1;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(292, 140);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(125, 27);
            this.textBoxInput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelHasil);
            this.Controls.Add(this.buttonCheck);
            this.Name = "Form1";
            this.Text = "Cek Tanda Bilangan";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelHasil;
        private System.Windows.Forms.TextBox textBoxInput;
    }
}
