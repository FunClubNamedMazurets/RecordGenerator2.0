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
    public partial class FormaZvtGrid : Form
    {
        public FormaZvtGrid()
        {
            InitializeComponent();
        }

        private void formaZvtsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.formaZvtsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.generatorDataSet);

        }

        private void FormaZvtGrid_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "generatorDataSet.FormaZvts". При необходимости она может быть перемещена или удалена.
            this.formaZvtsTableAdapter.Fill(this.generatorDataSet.FormaZvts);

        }
    }
}
