using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace vezba4PIT
{
    public partial class Statistika : Form
    {
        public Statistika()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Statistika_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "PunoIme";
            comboBox1.ValueMember = "AutorID";
            comboBox1.DataSource = Autor.UcitajSve();
            comboBox1.SelectedIndex = -1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Izaberite autora");
                return;
            }
            int god = (int)numericUpDown1.Value;

            int autor = (int)comboBox1.SelectedValue;


            chart1.Series[0].Points.Clear();  


            try
            {

                dataGridView1.DataSource = cStatistika.StatistikaIznajmljivanja(god, autor);

                chart1.Series[0].XValueType = ChartValueType.Int32;
                chart1.Series[0].YValueType = ChartValueType.Int32;
                chart1.Series[0].XValueMember = "Godina";
                chart1.Series[0].YValueMembers = "Broj";

                chart1.DataSource = dataGridView1.DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            chart1.Series[0].Points.Clear();

        }
    }
}
