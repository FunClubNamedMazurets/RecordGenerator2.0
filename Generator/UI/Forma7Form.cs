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
    public partial class Forma7Form : Form
    {
        #region Fields

        private readonly IGenerator<Forma7> _forma7Generator;
        private readonly IBaseService<Forma7> _forma7Service;

        #endregion

        #region Ctor
        public Forma7Form()
        {
            InitializeComponent();
            _forma7Generator = new Forma7Generator();
            _forma7Service = new Forma7Service();
        }
        #endregion

        #region Methods

        private void Forma7Form_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var forma7Model = PrepareModel();
            _forma7Generator.Generate(forma7Model);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var forma7Model = PrepareModel();

            if (string.IsNullOrEmpty(Id.Text) || Id.Text == "0")
            {
                _forma7Service.Insert(forma7Model);
                Id.Text = forma7Model?.Id.ToString();
                LoadComboBox(selectedLast: true);
            }
            else
            {
                _forma7Service.Update(forma7Model);
                LoadComboBox(selectedCurrent: true);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (KeyValuePair<int, string>)comboBox1.SelectedItem;
            var dodatoc4 = _forma7Service.GetById(item.Key);

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
                Type type = typeof(Forma7);

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

        private Forma7 PrepareModel()
        {
            var model = new Forma7();
            FormHelper.InputsToModel(this, model);

            return model;
        }

        private void LoadComboBox(bool selectedLast = false, bool selectedCurrent = false)
        {
            var temp = comboBox1?.SelectedIndex;
            var source = _forma7Service.GetAll().Select(x => new { Key = x.Id, Value = x.Id.ToString() + "; " + x.Input_1_код + "; " + x.Input_10_респондент_найменування }).ToList();

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
