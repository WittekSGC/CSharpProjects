using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace WFA_Valetova
{
    public partial class TheoryShowingForm : Form
    {
        string[] arr;
        public TheoryShowingForm()
        {
            FileStream text = new FileStream("..\\..\\Resources\\theory.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(text);

            string fullText = streamReader.ReadToEnd();
            arr = fullText.Split('\n');

            InitializeComponent();
        }

        private void TheoryShowingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TheoryShowingForm_Load(object sender, EventArgs e)
        {
            picker.SelectedIndex = 0;
            theoryText.Text = arr[0];
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            theoryText.Text = arr[picker.SelectedIndex];
        }
    }
}
