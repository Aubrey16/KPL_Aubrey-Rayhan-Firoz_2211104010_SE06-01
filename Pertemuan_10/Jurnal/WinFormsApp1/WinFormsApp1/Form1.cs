using System;
using System.Windows.Forms;

namespace modul12_NIM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtAngka1.Text);
                int b = int.Parse(txtAngka2.Text);

                int hasil = CariNilaiPangkat(a, b);
                lblHasil.Text = $"Hasil: {hasil}";
            }
            catch (FormatException)
            {
                lblHasil.Text = "Input harus berupa angka bulat.";
            }
        }

        public int CariNilaiPangkat(int a, int b)
        {
            if (b == 0)
                return 1;
            if (b < 0)
                return -1;
            if (b > 10 || a > 100)
                return -2;

            int hasil = 1;
            try
            {
                checked
                {
                    for (int i = 0; i < b; i++)
                    {
                        hasil *= a;
                    }
                }
            }
            catch (OverflowException)
            {
                return -3;
            }

            return hasil;
        }
    }
}
