﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //open new form for dodatoc4
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Dodatoc4Form dodatoc4Form = new Dodatoc4Form();
            dodatoc4Form.ShowDialog();
        }

        private void dodatoc4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dodatoc4Grid dodatoc4Grid = new Dodatoc4Grid();
            dodatoc4Grid.ShowDialog();
        }

        //open new form for dodatoc1
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Dodatoc1Form dodatoc1Form = new Dodatoc1Form();
            dodatoc1Form.ShowDialog();
        }

        //open new form for dodatoc1
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Dodatoc2Form dodatoc2Form = new Dodatoc2Form();
            dodatoc2Form.ShowDialog();
        }
    }
}
