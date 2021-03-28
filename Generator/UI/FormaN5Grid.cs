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
    public partial class FormaN5Grid : Form
    {
        public FormaN5Grid()
        {
            InitializeComponent();
        }

        private void formaN5BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.formaN5BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.generatorDataSet);

        }

        private void FormaN5Grid_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "generatorDataSet.FormaN5". При необходимости она может быть перемещена или удалена.
            this.formaN5TableAdapter.Fill(this.generatorDataSet.FormaN5);

        }
    }
}
