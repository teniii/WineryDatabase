using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVinuri f = new FormVinuri();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAngajati f = new FormAngajati();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormUtilaje f = new FormUtilaje();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormClienti f = new FormClienti();
            f.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormRepartizareParcele f = new FormRepartizareParcele();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormPremii f = new FormPremii();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormConcursuri f = new FormConcursuri();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormEvenimenteInterne f = new FormEvenimenteInterne();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormParcele f = new FormParcele();
            f.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FormIstoricEvenimente f = new FormIstoricEvenimente();
            f.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FormComenziSpeciale f = new FormComenziSpeciale();
            f.Show();
        }
    }
}
