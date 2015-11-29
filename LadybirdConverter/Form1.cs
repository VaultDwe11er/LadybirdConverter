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
            tbOutput.Text = ReverseLine(tbInput.Text);
        }

        private void btnConvertFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            dialog.ShowDialog();

            if (dialog.SelectedPath != "")
            {
                DirectoryInfo dir = new DirectoryInfo(dialog.SelectedPath);
                string outPath = dir.Parent.FullName + "/" + Path.GetFileName(dir.FullName) + "_reversed";

                if (!Directory.Exists(outPath))
                {
                    try
                    {
                        Directory.CreateDirectory(outPath);
                    }
                    catch (Exception up)
                    {
                        throw up;
                    }
                }

                foreach (var file in dir.GetFiles())
                {
                    string[] lines = File.ReadAllLines(file.FullName);
                    string[] outLines = ReverseAllLines(lines);

                    string fileName = file.Name;

                    using (var dummy = File.Create(outPath + "/" + fileName))
                    {
                    }
                    File.WriteAllLines(outPath + "/" + fileName, outLines);
                }

                MessageBox.Show("Done!");
            }
        }

        private string[] ReverseAllLines(string[] lines)
        {
            List<string> returnLines = new List<string>();
            string convertLine = "";

            for(int i = 0; i<lines.Length; i++)
            {
                string line = lines[i];

                if (line.Length == 0)
                {
                    if (convertLine.Length > 0)
                    {
                        convertLine = convertLine.Substring(0, convertLine.Length - 2);
                        returnLines.Add(ReverseLine(convertLine));
                        convertLine = "";
                    }
                    returnLines.Add(lines[i]);
                }
                else if (line[0] == '>')
                {
                    if (convertLine.Length > 0)
                    {
                        convertLine = convertLine.Substring(0, convertLine.Length - 2);
                        returnLines.Add(ReverseLine(convertLine));
                        convertLine = "";
                    }
                    returnLines.Add(lines[i]);
                }
                else
                {
                    convertLine += line + "\r\n";
                }                    
            }
            return returnLines.ToArray();
        }

        private string ReverseLine(string line)
        {
            string returnLine = "";

            foreach (char c in line.Reverse())
            {
                switch (c)
                {
                    case 'a':
                    case 'A':
                        returnLine += "T";
                        break;
                    case 'c':
                    case 'C':
                        returnLine += "G";
                        break;
                    case 'g':
                    case 'G':
                        returnLine += "C";
                        break;
                    case 't':
                    case 'T':
                        returnLine += "A";
                        break;
                    case '\r':
                        returnLine += '\n';
                        break;
                    case '\n':
                        returnLine += '\r';
                        break;
                    default:
                        returnLine += "N";
                        break;
                }
            }
            return returnLine;
        }

    }
}
