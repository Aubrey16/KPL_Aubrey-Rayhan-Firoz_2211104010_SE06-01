using System;
using System.Windows.Forms;

namespace tpmodul12_2211104010
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string CariTandaBilangan(int a)
        {
            if (a < 0)
                return "Negatif";
            else if (a > 0)
                return "Positif";
            else
                return "Nol";
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxInput.Text, out int inputAngka))
            {
                string hasil = CariTandaBilangan(inputAngka);
                labelHasil.Text = $"Tanda bilangan: {hasil}";
            }
            else
            {
                labelHasil.Text = "Input tidak valid!";
            }
        }
    }
}
