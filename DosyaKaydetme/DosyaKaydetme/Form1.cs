using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DosyaKaydetme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            string metin = tbKaydet.Text;

            FileStream fs = new FileStream("Kaydet.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            // StreamWriter sw = new StreamWriter("Kaydet.txt");

            sw.WriteLine(metin);
            sw.Close();
            MessageBox.Show("Dosya Kaydedildi.", "Kayıt Onay", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Oku_Click(object sender, EventArgs e)
        {
            string metin;
            lbOku.Items.Clear();
            FileStream fs = new FileStream("Kaydet.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            metin = sr.ReadLine();
            while (metin != null)
            {
                lbOku.Items.Add(metin);
                metin = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            MessageBox.Show("Okuma Başarılı", "Okuma Onay", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Emin Misiniz ?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (System.IO.File.Exists(@"Kaydet.txt"))
                {
                    System.IO.File.Delete(@"Kaydet.txt");
                }
                MessageBox.Show("Dosya Silindi", "Silme Onay", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi", "Silme Red", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
