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
    public partial class Dodatoc5Form : Form
    {
        #region Fields

        private readonly IGenerator<Dodatoc5> _dodatoc5Generator;
        private readonly IBaseService<Dodatoc5> _dodatoc5Service;

        #endregion

        #region Ctor
        public Dodatoc5Form()
        {
            InitializeComponent();
            _dodatoc5Generator = new Dodatoc5Generator(false);
            _dodatoc5Service = new Dodatoc5Service();
        }

        #endregion

        #region Methods

        private void Dodatoc5Form_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        //generate
        private void button1_Click(object sender, EventArgs e)
        {
            var dodatok5Model = PrepareModel();
            _dodatoc5Generator.Generate(dodatok5Model);
        }

        //save form to db
        private void button2_Click(object sender, EventArgs e)
        {
            var dodatoc5Model = PrepareModel();

            if (string.IsNullOrEmpty(Id.Text) || Id.Text == "0")
            {
                _dodatoc5Service.Insert(dodatoc5Model);
                Id.Text = dodatoc5Model?.Id.ToString();
                LoadComboBox(selectedLast: true);
            }
            else
            {
                _dodatoc5Service.Update(dodatoc5Model);
                LoadComboBox(selectedCurrent: true);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (KeyValuePair<int, string>)comboBox1.SelectedItem;
            var dodatoc4 = _dodatoc5Service.GetById(item.Key);

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
                Type type = typeof(Dodatoc5);

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

        private Dodatoc5 PrepareModel()
        {
            var model = new Dodatoc5();
            FormHelper.InputsToModel(this, model);

            return model;
        }

        private void LoadComboBox(bool selectedLast = false, bool selectedCurrent = false)
        {
            var temp = comboBox1?.SelectedIndex;
            var source = _dodatoc5Service.GetAll().Select(x => new { Key = x.Id, Value = x.Id.ToString() + "; " + x.Input_1_число + "; " + x.Input_15_назва_органу }).ToList();

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