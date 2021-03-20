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
    public partial class Dodatoc2Form : Form
    {
        #region Fields

        private readonly IGenerator<Dodatoc2> _dodatoc2Generator;
        private readonly Dodatoc2Service _dodatoc2Service;

        #endregion

        #region Ctor

        public Dodatoc2Form()
        {
            InitializeComponent();
            _dodatoc2Generator = new Dodatoc2Generator(true);
            _dodatoc2Service = new Dodatoc2Service();
        }

        #endregion

        #region Methods

        private void Dodatoc2Form_Load(object sender, EventArgs e)
        {
            //LoadComboBox();
        }

        //generate
        private void button1_Click(object sender, EventArgs e)
        {
            var dodatoc2Model = PrepareModel();
            _dodatoc2Generator.Generate(dodatoc2Model);
        }

        //save form to db
        private void button2_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Utilities

        private Dodatoc2 PrepareModel()
        {
            var model = new Dodatoc2();
            FormHelper.InputsToModel(this, model, true);
            
            return model;
        }

        #endregion
    }
}
