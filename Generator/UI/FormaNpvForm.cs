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
    public partial class FormaNpvForm : Form
    {
        #region Fields

        private readonly IGenerator<FormaNpv> _formaNpvGenerator;
        private readonly IBaseService<FormaNpv> _formaNpvService;

        #endregion

        #region Ctor
        public FormaNpvForm()
        {
            InitializeComponent();
            _formaNpvGenerator = new FormaNpvGenerator(false);
            _formaNpvService = new FormaNpvService();
        }
        #endregion

        #region Methods

        private void FormaNpvForm_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formaNpvModel = PrepareModel();
            _formaNpvGenerator.Generate(formaNpvModel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formaNpvModel = PrepareModel();

            if (string.IsNullOrEmpty(Id.Text) || Id.Text == "0")
            {
                _formaNpvService.Insert(formaNpvModel);
                Id.Text = formaNpvModel?.Id.ToString();
                LoadComboBox(selectedLast: true);
            }
            else
            {
                _formaNpvService.Update(formaNpvModel);
                LoadComboBox(selectedCurrent: true);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (KeyValuePair<int, string>)comboBox1.SelectedItem;
            var dodatoc4 = _formaNpvService.GetById(item.Key);

            if (dodatoc4 != null)
            {
                Type type = dodatoc4.GetType();

                foreach (var property in type.GetProperties().OrderBy(x => x.Name))
                {
                    PropertyInfo piShared = type.GetProperty(property.Name);
                    var control = this.Controls.Find(property.Name, true).FirstOrDefault();
                    control.Text = property.GetValue(dodatoc4)?.ToString();
                }
            }
            else
            {
                Type type = typeof(FormaNpv);

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

        private FormaNpv PrepareModel()
        {
            var model = new FormaNpv();
            FormHelper.InputsToModel(this, model);

            return model;
        }

        private void LoadComboBox(bool selectedLast = false, bool selectedCurrent = false)
        {
            var temp = comboBox1?.SelectedIndex;
            var source = _formaNpvService.GetAll().Select(x => new { Key = x.Id, Value = x.Id.ToString() + "; " + x.Input_1_посада_роботодавця + "; " + x.Input_2_число }).ToList();

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
