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
    public partial class Dodatoc5Form : Form
    {
        #region Fields

        private readonly IGenerator<Dodatoc5> _dodatok5Generator;
        // private readonly Dodatoc1Service _dodatoc1Service;

        #endregion

        #region Ctor
        public Dodatoc5Form()
        {
            InitializeComponent();
            _dodatok5Generator = new Dodatoc5Generator(false);
            //   _dodatok5Generator = new Dodatoc5Generator();
        }

        #endregion

        #region Methods

        private void button1_Click(object sender, EventArgs e)
        {
            var dodatok5Model = PrepareModel();
            _dodatok5Generator.Generate(dodatok5Model);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Utilities

        private Dodatoc5 PrepareModel()
        {
            var model = new Dodatoc5();
            FormHelper.InputsToModel(this, model);

            return model;
        }

        #endregion
    }
}
