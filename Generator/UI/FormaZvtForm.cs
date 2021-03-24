using Domain.Data.Entities;
using Domain.Generators;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        private readonly IBaseService<FormaZvt> _formaZvtService;

        #endregion

        #region Ctor

        public FormaZvtForm()
        {
            InitializeComponent();
            _formaZvtGenerator = new FormaZvtGenerator(false);
            _formaZvtService = new FormaZvtService();
        }

        #endregion

        #region Methods

        private void FormaZvtForm_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formaZvtModel = PrepareModel();
            _formaZvtGenerator.Generate(formaZvtModel);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formaZvtModel = PrepareModel();

            if (string.IsNullOrEmpty(Id.Text) || Id.Text == "0")
            {
                _formaZvtService.Insert(formaZvtModel);
                Id.Text = formaZvtModel?.Id.ToString();
                LoadComboBox(selectedLast: true);
            }
            else
            {
                _formaZvtService.Update(formaZvtModel);
                LoadComboBox(selectedCurrent: true);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (KeyValuePair<int, string>)comboBox1.SelectedItem;
            var dodatoc4 = _formaZvtService.GetById(item.Key);

            if (dodatoc4 != null)
            {
                Type type = dodatoc4.GetType();

                foreach (var property in type.GetProperties().OrderBy(x => x.Name))
                {
                    PropertyInfo piShared = type.GetProperty(property.Name);
                    var control = this.Controls.Find(property.Name, true).FirstOrDefault();
                    control.Text = property.GetValue(dodatoc4).ToString();
                }
            }
            else
            {
                Type type = typeof(FormaZvt);

                foreach (var property in type.GetProperties().OrderBy(x => x.Name))
                {
                    PropertyInfo piShared = type.GetProperty(property.Name);
                    var control = this.Controls.Find(property.Name, true).FirstOrDefault();
                    control.Text = "";
                }
            }
        }

        #endregion

        #region Utilities

        private FormaZvt PrepareModel()
        {
            var model = new FormaZvt();
            FormHelper.InputsToModel(this, model);

            return model;
        }

        private void LoadComboBox(bool selectedLast = false, bool selectedCurrent = false)
        {
            var temp = comboBox1?.SelectedIndex;
            var source = _formaZvtService.GetAll().Select(x => new { Key = x.Id, Value = x.Id.ToString() + "; " + x.Input_1_назва_організації_профспілки + "; " + x.Input_2_рік }).ToList();

            SortedDictionary<int, string> dictionarySource = new SortedDictionary<int, string>();
            dictionarySource.Add(0, "Add new");

            foreach (var item in source)
            {
                dictionarySource.Add(item.Key, item.Value);
            }

            comboBox1.DataSource = new BindingSource(dictionarySource, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";

            if (selectedLast)
            {
                comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
            }

            if (selectedCurrent && temp != null)
            {
                comboBox1.SelectedIndex = (int)temp;
            }
        }

        #endregion
    }
}
