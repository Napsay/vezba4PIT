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
    public partial class FOaplikaciji : Form
    {
        public FOaplikaciji()
        {
            InitializeComponent();
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectedNodeText = e.Node.Text;
            switch (selectedNodeText)
            {
                case "Opste informacije":
                    label1.Text = "Klikom na listView selektuje se autor i njegovi podaci se prikazuju u pojedinačnim poljima sa leve strane forme.\n\nPri promeni šifre u polju Šifra, u pojedinačnim poljima forme se prikazuju podaci autora sa zadatom šifrom i selektuje se izabran čitalac u listView kontroli.\n\n Ako ne postoji čitalac sa unetom šifrom sadržaj svih polja sa leve strane se briše i prikazuje se  opomena da ne postoji čitalac sa unetom šifrom. \n\nDugme za unos postaje aktivno.";
                    break;
                case "Unos novog autora":
                    label1.Text = "Klikom na dugme unesi upisuje se nov autor i pri tome osvežava prikaz u listView kontroli.\n\nPri unosu novog čitaoca, potrebno je uneti obavezno sledeća polja: matični broj, ime i prezime. \nAdresa, nije obavezno polje i može se uneti kasnije. Šifru čitaoca ne unosimo, već je kreira sama baza.\n\nPosle uspešnog unosa, osvežava se prikaz aktivnosti u listView i selektuje se poslednja aktivnost koja je ujedno i novouneta.\n Time će se podaci o njoj, zajedno sa kreiranom šifrom prikazati u levom delu forme.\n\nTEST PRIMER: ako se u polja za matični broj unese string koji nema tačno 13 karaktera i ako karakteri nisu brojevi aplikacija prikazuje opomenu.";
                    break;
                case "Statisticki pregled":
                    label1.Text = "Klikom na dugme prikazi.....";
                    break;
                case "Zatvaranje aplikacije":
                    label1.Text = "Klikom na dugme Izlaz zatvara se aplikacija.";
                    break;
                case "Dodatni zahtevi":
                    label1.Text = "Dodatni zahtevi. Dugme Upiši čitaoca postaje aktivno tek kada su sva polja sa leve strane forme prazna.";
                    break;
                case "Autor":
                    label1.Text = "Autor: Stefan Karac";
                    break;


            }

        }
    }
}
