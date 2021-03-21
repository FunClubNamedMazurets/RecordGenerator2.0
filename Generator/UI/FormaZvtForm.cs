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
    public partial class FormaZvtForm : Form
    {
        #region Fields

        private readonly IGenerator<FormaZvt> _formaZvtGenerator;
       // private readonly Dodatoc1Service _dodatoc1Service;

        #endregion

        #region Ctor

        public FormaZvtForm()
        {
            InitializeComponent();
            _formaZvtGenerator = new FormaZvtGenerator(false);
         //   _dodatoc2Service = new Dodatoc2Service();
        }
        #endregion

        #region Methods

        private void button1_Click(object sender, EventArgs e)
        {
            var formaZvtModel = PrepareModel();
            _formaZvtGenerator.Generate(formaZvtModel);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Utilities

        private FormaZvt PrepareModel()
        {
            var model = new FormaZvt();
            FormHelper.InputsToModel(this, model);

            return model;
        }

        #endregion
    }
}
