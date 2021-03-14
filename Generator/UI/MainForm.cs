using System;
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

        //open new form for dodatoc2
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Dodatoc2Form dodatoc2Form = new Dodatoc2Form();
            dodatoc2Form.ShowDialog();
        }

        //open new form for dodatoc5
        private void dodatoc5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dodatoc5Form dodatoc5Form = new Dodatoc5Form();
            dodatoc5Form.ShowDialog();
        }

        //open new form for forma7tnv
        private void forma7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forma7Form forma7Form = new Forma7Form();
            forma7Form.ShowDialog();
        }

        //open new form for formaN1
        private void forma7ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormaN1Form formaN1Form = new FormaN1Form();
            formaN1Form.ShowDialog();
        }

        //open new form for formaN5
        private void formaN5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormaN5Form formaN5Form = new FormaN5Form();
            //forma7Form.ShowDialog();
        }
    }
}
