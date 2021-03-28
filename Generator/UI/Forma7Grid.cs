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
    public partial class Forma7Grid : Form
    {
        public Forma7Grid()
        {
            InitializeComponent();
        }

        private void forma7BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.forma7BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.generatorDataSet);

        }

        private void Forma7Grid_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "generatorDataSet.Forma7". При необходимости она может быть перемещена или удалена.
            this.forma7TableAdapter.Fill(this.generatorDataSet.Forma7);

        }
    }
}
