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

namespace Laba6Z1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a;           
            Console.WriteLine("Введите строку ");
            a = textBox1.Text;
            Console.Read();
            textBox5.Text = a.Substring(0, a.IndexOf(" ")) + a.Substring(a.LastIndexOf(" "));
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (o.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(o.FileName, Encoding.Default);
            }
        }
    }
}
