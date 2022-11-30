using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vezba4PIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Autor> autori = Autor.UcitajSve();

            NapuniListView(autori);

            listView1.FullRowSelect = true;
            listView1.Items[0].Selected = true;
        }

        private void NapuniListView(List<Autor> lista)
        {
            listView1.Items.Clear();
            foreach (Autor a in lista)
            {
                string[] podaci = { a.AutorID.ToString(), a.Ime, a.Prezime, a.DatumRodjenja.ToString("dd/MM/yyyy") };
                ListViewItem lvi = new ListViewItem(podaci);
                listView1.Items.Add(lvi);
            }

        }
        private void PrikaziAutora(Autor x)
        {
            textBox1.Text = x.AutorID.ToString();
            textBox2.Text = x.Ime;
            textBox3.Text = x.Prezime;
            maskedTextBox1.Text = x.DatumRodjenja.ToString("dd-MM-yyyy");
        }
        private void OcistiPodatke()
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            maskedTextBox1.Text = maskedTextBox1.Mask;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string sifra = textBox1.Text;
            Autor izabran = new Autor();

            var item = listView1.FindItemWithText(sifra, false, 0, false);
            if (item != null)
            {
                izabran.AutorID = Convert.ToInt32(sifra);
                izabran.Ime = item.SubItems[1].Text;
                izabran.Prezime = item.SubItems[2].Text;
                izabran.DatumRodjenja = Convert.ToDateTime(item.SubItems[3].Text);
                PrikaziAutora(izabran);

                DialogResult dr = MessageBox.Show("Da li si siguran da zelis da obrises izabranog autora?", "Pritisnite neko od ovih dugmadi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    if (izabran.Obrisi())
                    {

                        NapuniListView(Autor.UcitajSve());
                        OcistiPodatke();
                    }

                }
            }
            else
            {
                MessageBox.Show("Nije pronadjen autor sa unetom sifrom");
                OcistiPodatke();
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            int sifra = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
            Autor x = new Autor();
            x.AutorID = sifra;
            x.Ime = listView1.SelectedItems[0].SubItems[1].Text;
            x.Prezime = listView1.SelectedItems[0].SubItems[2].Text;
            x.DatumRodjenja = Convert.ToDateTime(listView1.SelectedItems[0].SubItems[3].Text);
            PrikaziAutora(x);

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Statistika frm = new Statistika();
            frm.ShowDialog();

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FOaplikaciji foap = new FOaplikaciji();
            foap.ShowDialog();
        }
    }
}
