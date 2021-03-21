using Domain.Data.Entities;
using Domain.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Helpers;

namespace UI
{
    public partial class Forma7Form : Form
    {
        #region Fields

        private readonly IGenerator<Forma7> _forma7Generator;
        // private readonly Forma7Service _forma7Service;

        #endregion

        #region Ctor
        public Forma7Form()
        {
            InitializeComponent();
            _forma7Generator = new Forma7Generator(false);
            //   _forma7Service = new Forma7Service();
        }
        #endregion

        #region Methods
        private void button1_Click(object sender, EventArgs e)
        {
            var forma7Model = PrepareModel();
            _forma7Generator.Generate(forma7Model);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Utilities

        private Forma7 PrepareModel()
        {
            var model = new Forma7();
            FormHelper.InputsToModel(this, model);

            return model;
        }

        #endregion
    }
}
