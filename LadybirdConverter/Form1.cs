using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LadybirdConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string input = tbInput.Text;
            string output = "";

            input = new string(input.Reverse().ToArray());

            foreach (char c in input)
            {
                switch (c)
                {
                    case 'a':
                    case 'A':
                        output += "T";
                        break;
                    case 'c':
                    case 'C':
                        output += "G";
                        break;
                    case 'g':
                    case 'G':
                        output += "C";
                        break;
                    case 't':
                    case 'T':
                        output += "A";
                        break;
                    case '\r':
                        output += '\n';
                        break;
                    case '\n':
                        output += '\r';
                        break;
                    default:
                        output += "N";
                        break;
                }
            }
            tbOutput.Text = output;
        }
    }
}
