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
    public partial class Dodatoc5Grid : Form
    {
        public Dodatoc5Grid()
        {
            InitializeComponent();
        }

        private void dodatoc5BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dodatoc5BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.generatorDataSet);

        }

        private void Dodatoc5Grid_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "generatorDataSet.Dodatoc5". При необходимости она может быть перемещена или удалена.
            this.dodatoc5TableAdapter.Fill(this.generatorDataSet.Dodatoc5);

        }
    }
}
