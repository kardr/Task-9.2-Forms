using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Task_9._2_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("text.txt");
                StreamWriter sw = new StreamWriter("text2.txt");
                while (sr.EndOfStream != true)
                {
                    string s = sr.ReadLine();
                    string s2 = "";
                    for (int i = 1; i < s.Length; i += 2)
                    {
                        s2 += s[i];
                    }
                    sw.WriteLine(s2);
                }
                sr.Close();
                sw.Close();
            }
            catch (Exception E)
            {
               MessageBox.Show(E.Message);
            }
        }
    }
}
