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
    public partial class FormaNtGrid : Form
    {
        public FormaNtGrid()
        {
            InitializeComponent();
        }

        private void formaNtsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.formaNtsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.generatorDataSet);

        }

        private void FormaNtGrid_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "generatorDataSet.FormaNts". При необходимости она может быть перемещена или удалена.
            this.formaNtsTableAdapter.Fill(this.generatorDataSet.FormaNts);

        }
    }
}
