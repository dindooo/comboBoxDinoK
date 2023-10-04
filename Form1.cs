using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comboBoxDinoK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string izabrano = cmbOdabir.SelectedItem.ToString();
            txtIspis.Text = "Izabrali ste zanimanje: \r\n "+ izabrano;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
