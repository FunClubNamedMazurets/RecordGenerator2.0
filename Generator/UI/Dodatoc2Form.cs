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
            LoadComboBox();
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
            var dodatoc2Model = PrepareModel();

            if (string.IsNullOrEmpty(Id.Text) || Id.Text == "0")
            {
                _dodatoc2Service.Insert(dodatoc2Model);
                Id.Text = dodatoc2Model?.Id.ToString();
                LoadComboBox(selectedLast: true);
            }
            else
            {
                _dodatoc2Service.Update(dodatoc2Model);
                LoadComboBox(selectedCurrent: true);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (KeyValuePair<int, string>)comboBox1.SelectedItem;
            var dodatoc2 = _dodatoc2Service.GetById(item.Key);

            if (dodatoc2 != null)
            {
                Type type = dodatoc2.GetType();

                foreach (var property in type.GetProperties().OrderBy(x => x.Name))
                {
                    if (property.PropertyType != typeof(DynamicTable))
                    {
                        PropertyInfo piShared = type.GetProperty(property.Name);
                        var control = this.Controls.Find(property.Name, true).FirstOrDefault();
                        control.Text = property.GetValue(dodatoc2)?.ToString();
                    }
                    else
                    {
                        var control = (DataGridView)this.Controls.Find(property.Name, true).FirstOrDefault();

                        control.Rows.Clear();
                        control.Refresh();

                        var dynamicTable1 = (DynamicTable)property.GetValue(dodatoc2);
                        string[] subs = dynamicTable1.DataRaw.Split(Constants.Splitter);

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
                Type type = typeof(Dodatoc2);

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

        private Dodatoc2 PrepareModel()
        {
            var model = new Dodatoc2();
            FormHelper.InputsToModel(this, model, true);
            
            return model;
        }

        private void LoadComboBox(bool selectedLast = false, bool selectedCurrent = false)
        {
            var temp = comboBox1?.SelectedIndex;
            var source = _dodatoc2Service.GetAll().Select(x => new { Key = x.Id, Value = x.Id.ToString() + "; " + x.Input_1_орган_управління_освітою + "; " + x.Input_2_п_і_б }).ToList();

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
