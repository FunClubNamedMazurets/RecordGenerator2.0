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
    public partial class FormaNpvGrid : Form
    {
        public FormaNpvGrid()
        {
            InitializeComponent();
        }

        private void formaNpvsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.formaNpvsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.generatorDataSet);

        }

        private void FormaNpvGrid_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "generatorDataSet.FormaNpvs". При необходимости она может быть перемещена или удалена.
            this.formaNpvsTableAdapter.Fill(this.generatorDataSet.FormaNpvs);

        }
    }
}
