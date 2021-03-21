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
    public partial class FormaNtForm : Form
    {
        #region Fields

        private readonly IGenerator<FormaNt> _formaNtGenerator;
        // private readonly FormaNtService _formaNtService;

        #endregion

        #region Ctor
        public FormaNtForm()
        {
            InitializeComponent();
            _formaNtGenerator = new FormaNtGenerator();
            //   _formaNtService = new FormaNtService();
        }
        #endregion

        #region Methods
        private void button1_Click(object sender, EventArgs e)
        {
            var formaNtModel = PrepareModel();
            _formaNtGenerator.Generate(formaNtModel);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Utilities

        private FormaNt PrepareModel()
        {
            var model = new FormaNt();
            FormHelper.InputsToModel(this, model, true);

            return model;
        }

        #endregion


    }
}
