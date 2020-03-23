using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Valetova
{
    public partial class MainForm : Form
    {
        TheoryShowingForm theory = new TheoryShowingForm();
        AfinCezarForm Cezar = new AfinCezarForm();
        AlgPrimaForm prima = new AlgPrimaForm();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (prima.Visible == false)
                prima.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (theory.Visible == false)
                theory.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Cezar.Visible == false)
                Cezar.Show();
        }
    }
}
