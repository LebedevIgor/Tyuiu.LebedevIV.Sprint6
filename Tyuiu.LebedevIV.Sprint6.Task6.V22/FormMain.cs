using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.LebedevIV.Sprint6.Task6.V22.Lib;
using System.IO;

namespace Tyuiu.LebedevIV.Sprint6.Task6.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonDone_LIV_Click(object sender, EventArgs e)
        {
            textBoxResult_LIV.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonOpen_LIV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_LIV.ShowDialog();
            openFilePath = openFileDialogTask_LIV.FileName;
            textBoxInput_LIV.Text = File.ReadAllText(openFilePath);
            groupBoxEnter_LIV.Text = groupBoxEnter_LIV.Text + " " + openFileDialogTask_LIV.FileName;
            buttonDone_LIV.Enabled = true;
        }

        private void buttonHelp_LIV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
