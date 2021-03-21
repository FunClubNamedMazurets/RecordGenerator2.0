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
    public partial class FormaNpvForm : Form
    {
        #region Fields

        private readonly IGenerator<FormaNpv> _formaNpvGenerator;
        // private readonly FormaNpvService _formaNpvService;

        #endregion

        #region Ctor
        public FormaNpvForm()
        {
            InitializeComponent();
            _formaNpvGenerator = new FormaNpvGenerator(false);
            //   _formaNpvService = new FormaNpvService();
        }
        #endregion

        #region Methods
        private void button1_Click(object sender, EventArgs e)
        {
            var formaNpvModel = PrepareModel();
            _formaNpvGenerator.Generate(formaNpvModel);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Utilities

        private FormaNpv PrepareModel()
        {
            var model = new FormaNpv();
            FormHelper.InputsToModel(this, model);

            return model;
        }

        #endregion

    }
}
