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
    public partial class AfinCezarForm : Form
    {
        public AfinCezarForm()
        {
            InitializeComponent();
        }

        private void AfinCezarForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string giveText, returnText, langMode;
            int a, b;

            if (radioButton1.Checked)
                langMode = "eng";
            else
                langMode = "rus";

            giveText = textBox1.Text;
            a = (int)numericUpDown1.Value;
            b = (int)numericUpDown2.Value;
            if (giveText == "")
            {
                MessageBox.Show("Пусто!", "Ошибка!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                if (radioButton3.Checked)
                    returnText = Shifr(giveText, langMode, a, b);
                else
                    returnText = UnShifr(giveText, langMode, a, b);
                textBox2.Text = returnText;
            }

        }

        //user methods
        //3    //5
        public string Shifr(string text, string mode, int a, int b)
        {
            string shifrText = "", engAlf = "abcdefghijklmnopqrstuvwxyz", rusAlf = "абвгдежзийклмнопрстуфхцчшщъыьэюя";
            text = text.ToLower();
            bool find = false;
            if (mode == "eng")
            {
                if (a >= b || b >= 26)
                {
                    //debug
                    //Console.WriteLine("error indexer");
                    //
                    MessageBox.Show("Error indexer!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return null;
                }
                else
                    for (int i = 0; i < text.Length; i++)
                    {
                        for (int j = 0; j < engAlf.Length; j++)
                        {
                            if (text[i] == engAlf[j])
                            {
                                find = true;
                                shifrText += engAlf[(a * j + b) % 26];
                            }
                        }
                        if (!find)
                        {
                            shifrText += text[i];
                        }
                        find = false;
                    }
                //degug
                //Console.WriteLine(shifrText);
                //
                return shifrText;
            }
            else
            if (mode == "rus")
            {
                if (a >= b || b >= 32)
                {
                    //debug
                    //Console.WriteLine("error indexer");
                    //
                    MessageBox.Show("Error indexer!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return null;
                }
                else
                    for (int i = 0; i < text.Length; i++)
                    {
                        for (int j = 0; j < rusAlf.Length; j++)
                        {
                            if (text[i] == rusAlf[j])
                            {
                                find = true;
                                shifrText += rusAlf[(a * j + b) % 32];
                            }
                        }
                        if (!find)
                        {
                            shifrText += text[i];
                        }
                        find = false;
                    }
                //debug
                //Console.WriteLine(shifrText);
                //
                return shifrText;
            }
            else
            {
                MessageBox.Show("Unknowned text mode!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return null;
            }
        }

        public string UnShifr(string text, string mode, int a, int b)
        {
            string unShifrText = "", engAlf = "abcdefghijklmnopqrstuvwxyz", rusAlf = "абвгдежзийклмнопрстуфхцчшщъыьэюя";
            text = text.ToLower();
            bool find = false;
            //a * x + b mod 26
            if (mode == "eng")
            {
                if (a >= b || b >= 26)
                {
                    //debug
                    //Console.WriteLine("error indexer");
                    //
                    MessageBox.Show("Error indexer!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return null;
                }
                else
                    for (int i = 0; i < text.Length; i++)
                    {
                        for (int j = 0; j < engAlf.Length; j++)
                        {
                            if (text[i] == engAlf[(a * j + b) % 26])
                            {
                                find = true;
                                unShifrText += engAlf[j];
                            }

                        }
                        if (!find)
                        {
                            unShifrText += text[i];
                        }
                        find = false;
                    }
                //degug
                //Console.WriteLine(unShifrText);
                //
                return unShifrText;
            }
            else
            if (mode == "rus")
            {
                if (a >= b || b >= 32)
                {
                    //debug
                    // Console.WriteLine("error indexer");
                    //
                    MessageBox.Show("Error indexer!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return null;
                }
                else
                    for (int i = 0; i < text.Length; i++)
                    {
                        for (int j = 0; j < rusAlf.Length; j++)
                        {
                            if (text[i] == rusAlf[(a * j + b) % 32])
                            {
                                find = true;
                                unShifrText += rusAlf[j];
                            }

                        }
                        if (!find)
                        {
                            unShifrText += text[i];
                        }
                        find = false;
                    }
                //debug
                //Console.WriteLine(unShifrText);
                //
                return unShifrText;
            }
            else
            {
                MessageBox.Show("Unknowned text mode!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
