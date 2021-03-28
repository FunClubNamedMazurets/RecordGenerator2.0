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
    public partial class FormaN1Grid : Form
    {
        public FormaN1Grid()
        {
            InitializeComponent();
        }

        private void formaN1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.formaN1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.generatorDataSet);

        }

        private void FormaN1Grid_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "generatorDataSet.FormaN1". При необходимости она может быть перемещена или удалена.
            this.formaN1TableAdapter.Fill(this.generatorDataSet.FormaN1);

        }
    }
}
