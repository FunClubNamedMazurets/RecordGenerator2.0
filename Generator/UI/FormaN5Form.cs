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
    public partial class FormaN5Form : Form
    {
        #region Fields

        private readonly IGenerator<FormaN5> _formaN5Generator;
        // private readonly FormaN5Service _formaN5Service;

        #endregion

        #region Ctor
        public FormaN5Form()
        {
            InitializeComponent();
            _formaN5Generator = new FormaN5Generator(false);
            //   _formaNpvService = new FormaNpvService();
        }

        #endregion

        #region Methods
        private void button1_Click(object sender, EventArgs e)
        {
            var formaN5Model = PrepareModel();
            _formaN5Generator.Generate(formaN5Model);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Utilities

        private FormaN5 PrepareModel()
        {
            var model = new FormaN5();
            FormHelper.InputsToModel(this, model);

            return model;
        }

        #endregion
    }
}
