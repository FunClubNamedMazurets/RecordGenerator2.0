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
    public partial class FormaN1Form : Form
    {
        #region Fields

        private readonly IGenerator<FormaN1> _formaN1Generator;
        // private readonly FormaN1Service _formaN1Service;

        #endregion

        #region Ctor
        public FormaN1Form()
        {
            InitializeComponent();
            _formaN1Generator = new FormaN1Generator();
            //   _formaN1Service = new FormaN1Service();
        }

        #endregion

        #region Methods
        private void button1_Click(object sender, EventArgs e)
        {
            var formaN1Model = PrepareModel();
            _formaN1Generator.Generate(formaN1Model);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Utilities

        private FormaN1 PrepareModel()
        {
            var model = new FormaN1();
            FormHelper.InputsToModel(this, model, true);

            return model;
        }

        #endregion

    }
}
