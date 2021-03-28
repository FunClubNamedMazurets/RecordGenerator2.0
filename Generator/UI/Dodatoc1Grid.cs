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
    public partial class Dodatoc1Grid : Form
    {
        public Dodatoc1Grid()
        {
            InitializeComponent();
        }

        private void dodatoc1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dodatoc1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.generatorDataSet);

        }

        private void Dodatoc1Grid_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "generatorDataSet.Dodatoc1". При необходимости она может быть перемещена или удалена.
            this.dodatoc1TableAdapter.Fill(this.generatorDataSet.Dodatoc1);

        }
    }
}
