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

namespace ShadowCopy
{
    public partial class Form1 : Form
    {
        List<string> m_Extensions;

        public Form1()
        {
            InitializeComponent();

            txt_SourcePath.Text = Properties.Settings.Default.SourcePath;
        }

        private void btn_SelectSource_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txt_SourcePath.Text))
                folderBrowserDialog1.SelectedPath = txt_SourcePath.Text;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                txt_SourcePath.Text = folderBrowserDialog1.SelectedPath;


        }

        private void txt_SourcePath_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SourcePath = txt_SourcePath.Text;
        }

        private void btn_SelectTarget_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txt_TargetPath.Text))
                folderBrowserDialog1.SelectedPath = txt_TargetPath.Text;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                txt_TargetPath.Text = folderBrowserDialog1.SelectedPath;


        }

        private void txt_TargetPath_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.TargetPath = txt_SourcePath.Text;
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            GetFileExtensions();

            foreach (string ext in m_Extensions)
            {
                string[] fileList = Directory.GetFiles(txt_SourcePath.Text, "*." + ext);

                // Copy files.
                foreach (string f in fileList)
                {
                    // Remove path from the file name.
                    string fName = f.Substring(txt_SourcePath.Text.Length + 1);

                    // Kein Überschreiben im Ziel
                    File.Copy(Path.Combine(txt_SourcePath.Text, fName), Path.Combine(txt_TargetPath.Text, fName), false);
                }
            }
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void GetFileExtensions()
        {
            m_Extensions = new List<string>();
            m_Extensions.AddRange(txt_FileExtensions.Text.Split(' '));
        }
    }
}
