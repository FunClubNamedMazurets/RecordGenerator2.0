using Domain.Data.Entities;
using Domain.Generators;
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
using UI.Helpers;

namespace UI
{
    public partial class Dodatoc1Form : Form
    {
        #region Fields

        private readonly IGenerator<Dodatoc1> _dodatoc1Generator;
        //private readonly Dodatoc1Service _dodatoc1Service;

        #endregion

        #region Ctor

        public Dodatoc1Form()
        {
            InitializeComponent();
            _dodatoc1Generator = new Dodatoc1Generator();
           // _dodatoc2Service = new Dodatoc2Service();
        }
        #endregion

        #region Methods

        private void Dodatoc1Form_Load(object sender, EventArgs e)
        {
            //LoadComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dodatoc1Model = PrepareModel();
            _dodatoc1Generator.Generate(dodatoc1Model);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Utilities

        private Dodatoc1 PrepareModel()
        {
            var model = new Dodatoc1();
          
            FormHelper.InputsToModel(this, model, true);

            return model;
        }

        #endregion
    }
}
