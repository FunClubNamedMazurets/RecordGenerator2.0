using Domain.Data.Entities;
using Domain.Services;
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
    public partial class Dodatoc4Grid : Form
    {
        public Dodatoc4Grid()
        {
            InitializeComponent();
        }

        private void Dodatoc4Grid_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "generatorDataSet.Dodatoc4". При необходимости она может быть перемещена или удалена.
            this.dodatoc4TableAdapter.Fill(this.generatorDataSet.Dodatoc4);

        }

        private void dodatoc4BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dodatoc4BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.generatorDataSet);

        }
    }
}
