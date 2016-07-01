using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Integral
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bSelectAtributes_Click(object sender, EventArgs e)
        {
            SelectAtributesForm selectAtributesForm = new SelectAtributesForm();
            selectAtributesForm.ShowDialog();
        }

        private void bStartAuto_Click(object sender, EventArgs e)
        {
            ConfigForm configForm = new ConfigForm();
            configForm.ShowDialog();
        }


    }
}