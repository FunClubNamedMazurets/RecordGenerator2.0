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
    public partial class FormaN5Form : Form
    {
        #region Fields

        private readonly IGenerator<FormaN5> _formaN5Generator;
        private readonly IBaseService<FormaN5> _formaN5Service;

        #endregion

        #region Ctor
        public FormaN5Form()
        {
            InitializeComponent();
            _formaN5Generator = new FormaN5Generator(false);
            _formaN5Service = new FormaN5Service();
        }

        #endregion

        #region Methods

        private void FormaN5Form_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formaN5Model = PrepareModel();
            _formaN5Generator.Generate(formaN5Model);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formaN5Model = PrepareModel();

            if (string.IsNullOrEmpty(Id.Text) || Id.Text == "0")
            {
                _formaN5Service.Insert(formaN5Model);
                Id.Text = formaN5Model?.Id.ToString();
                LoadComboBox(selectedLast: true);
            }
            else
            {
                _formaN5Service.Update(formaN5Model);
                LoadComboBox(selectedCurrent: true);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (KeyValuePair<int, string>)comboBox1.SelectedItem;
            var dodatoc4 = _formaN5Service.GetById(item.Key);

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
                Type type = typeof(FormaN5);

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

        private FormaN5 PrepareModel()
        {
            var model = new FormaN5();
            FormHelper.InputsToModel(this, model);

            return model;
        }

        private void LoadComboBox(bool selectedLast = false, bool selectedCurrent = false)
        {
            var temp = comboBox1?.SelectedIndex;
            var source = _formaN5Service.GetAll().Select(x => new { Key = x.Id, Value = x.Id.ToString() + "; " + x.Input_12_п_і_б_професія_посада + "; " + x.Input_13_дата_складання_акта }).ToList();

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