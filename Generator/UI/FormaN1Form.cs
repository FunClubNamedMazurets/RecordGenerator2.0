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
    public partial class FormaN1Form : Form
    {
        #region Fields

        private readonly IGenerator<FormaN1> _formaN1Generator;
        private readonly IBaseService<FormaN1> _formaN1Service;

        #endregion

        #region Ctor
        public FormaN1Form()
        {
            InitializeComponent();
            _formaN1Generator = new FormaN1Generator();
            _formaN1Service = new FormaN1Service();
        }

        #endregion

        #region Methods

        private void FormaN1Form_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formaN1Model = PrepareModel();
            _formaN1Generator.Generate(formaN1Model);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formaN1Model = PrepareModel();

            if (string.IsNullOrEmpty(Id.Text) || Id.Text == "0")
            {
                _formaN1Service.Insert(formaN1Model);
                Id.Text = formaN1Model?.Id.ToString();
                LoadComboBox(selectedLast: true);
            }
            else
            {
                _formaN1Service.Update(formaN1Model);
                LoadComboBox(selectedCurrent: true);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (KeyValuePair<int, string>)comboBox1.SelectedItem;
            var formaN1 = _formaN1Service.GetById(item.Key);

            if (formaN1 != null)
            {
                Type type = formaN1.GetType();

                foreach (var property in type.GetProperties().OrderBy(x => x.Name))
                {
                    if (property.PropertyType != typeof(DynamicTable))
                    {
                        PropertyInfo piShared = type.GetProperty(property.Name);
                        var control = this.Controls.Find(property.Name, true).FirstOrDefault();
                        control.Text = property.GetValue(formaN1).ToString();
                    }
                    else
                    {
                        var control = (DataGridView)this.Controls.Find(property.Name, true).FirstOrDefault();

                        control.Rows.Clear();
                        control.Refresh();

                        var dynamicTable1 = (DynamicTable)property.GetValue(formaN1);
                        string[] subs = dynamicTable1.DataRaw.Split(';');

                        for (int i = 0; i < subs.Length; i += dynamicTable1.ColumnsCount)
                        {
                            var tempArr = new string[dynamicTable1.ColumnsCount];
                            for (int j = 0; j < dynamicTable1.ColumnsCount; j++)
                            {
                                tempArr[j] = subs[i + j];
                            }

                            control.Rows.Add(tempArr);
                        }
                    }
                }
            }
            else
            {
                Type type = typeof(FormaN1);

                foreach (var property in type.GetProperties().OrderBy(x => x.Name))
                {
                    if (property.PropertyType != typeof(DynamicTable))
                    {
                        PropertyInfo piShared = type.GetProperty(property.Name);
                        var control = this.Controls.Find(property.Name, true).FirstOrDefault();
                        control.Text = "";
                    }
                    else
                    {
                        var control = (DataGridView)this.Controls.Find(property.Name, true).FirstOrDefault();

                        control.Rows.Clear();
                        control.Refresh();
                    }
                }
            }
        }

        #endregion

        #region Utilities

        private FormaN1 PrepareModel()
        {
            var model = new FormaN1();
            FormHelper.InputsToModel(this, model, true);

            return model;
        }

        private void LoadComboBox(bool selectedLast = false, bool selectedCurrent = false)
        {
            var temp = comboBox1?.SelectedIndex;
            var source = _formaN1Service.GetAll().Select(x => new { Key = x.Id, Value = x.Id.ToString() + "; " + x.Input_1_посада_роботодавця + "; " + x.Input_6_п_і_б_потерпілого }).ToList();

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
