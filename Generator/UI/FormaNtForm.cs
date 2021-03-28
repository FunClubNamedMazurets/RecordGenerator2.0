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
    public partial class FormaNtForm : Form
    {
        #region Fields

        private readonly IGenerator<FormaNt> _formaNtGenerator;
        private readonly IBaseService<FormaNt> _formaNtService;

        #endregion

        #region Ctor
        public FormaNtForm()
        {
            InitializeComponent();
            _formaNtGenerator = new FormaNtGenerator();
            _formaNtService = new FormaNtService();
        }
        #endregion

        #region Methods

        private void FormaNtForm_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formaNtModel = PrepareModel();
            _formaNtGenerator.Generate(formaNtModel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formaNtModel = PrepareModel();

            if (string.IsNullOrEmpty(Id.Text) || Id.Text == "0")
            {
                _formaNtService.Insert(formaNtModel);
                Id.Text = formaNtModel?.Id.ToString();
                LoadComboBox(selectedLast: true);
            }
            else
            {
                _formaNtService.Update(formaNtModel);
                LoadComboBox(selectedCurrent: true);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (KeyValuePair<int, string>)comboBox1.SelectedItem;
            var formaNt = _formaNtService.GetById(item.Key);

            if (formaNt != null)
            {
                Type type = formaNt.GetType();

                foreach (var property in type.GetProperties().OrderBy(x => x.Name))
                {
                    if (property.PropertyType != typeof(DynamicTable))
                    {
                        PropertyInfo piShared = type.GetProperty(property.Name);
                        var control = this.Controls.Find(property.Name, true).FirstOrDefault();
                        control.Text = property.GetValue(formaNt)?.ToString();
                    }
                    else
                    {
                        var control = (DataGridView)this.Controls.Find(property.Name, true).FirstOrDefault();

                        control.Rows.Clear();
                        control.Refresh();

                        var dynamicTable1 = (DynamicTable)property.GetValue(formaNt);
                        string[] subs = dynamicTable1.DataRaw.Split(';');

                        for (int i = 0; i < subs.Length; i += dynamicTable1.ColumnsCount)
                        {
                            var tempArr = new string[dynamicTable1.ColumnsCount];
                            for (int j = 0; j < dynamicTable1.ColumnsCount; j++)
                            {
                                if (subs[i + j].Contains(Constants.Space))
                                {
                                    tempArr[j] = string.Empty;
                                }
                                else
                                {
                                    tempArr[j] = subs[i + j];
                                }
                            }

                            control.Rows.Add(tempArr);
                        }
                    }
                }
            }
            else
            {
                Type type = typeof(FormaNt);

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

        private FormaNt PrepareModel()
        {
            var model = new FormaNt();
            FormHelper.InputsToModel(this, model, true);

            return model;
        }

        private void LoadComboBox(bool selectedLast = false, bool selectedCurrent = false)
        {
            var temp = comboBox1?.SelectedIndex;
            var source = _formaNtService.GetAll().Select(x => new { Key = x.Id, Value = x.Id.ToString() + "; " + x.Input_1_посада_роботодавця + "; " + x.Input_35_стислий_виклад_обставин }).ToList();

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