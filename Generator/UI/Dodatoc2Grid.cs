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
    public partial class Dodatoc2Grid : Form
    {
        public Dodatoc2Grid()
        {
            InitializeComponent();
        }

        private void dodatoc2BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dodatoc2BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.generatorDataSet);

        }

        private void Dodatoc2Grid_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "generatorDataSet.Dodatoc2". При необходимости она может быть перемещена или удалена.
            this.dodatoc2TableAdapter.Fill(this.generatorDataSet.Dodatoc2);

        }
    }
}
