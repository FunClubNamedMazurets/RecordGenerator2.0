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
    public partial class Dodatoc4Form : Form
    {
        private readonly IGenerator<Dodatoc4> _dodatoc4Generator;
        private readonly Dodatoc4Service _dodatoc4Service;
        public Dodatoc4Form()
        {
            InitializeComponent();
            _dodatoc4Generator = new Dodatoc4Generator();
            _dodatoc4Service = new Dodatoc4Service();
        }

        private void Dodatoc4Form_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        //save form to db
        private void button2_Click(object sender, EventArgs e)
        {
            var dodatoc4Model = PrepareModel();

            if (string.IsNullOrEmpty(Id.Text) || Id.Text == "0")
            {
                _dodatoc4Service.Insert(dodatoc4Model);
                Id.Text = dodatoc4Model?.Id.ToString();           
                LoadComboBox(selectedLast: true);
            }
            else 
            { 
                _dodatoc4Service.Update(dodatoc4Model);
                LoadComboBox(selectedCurrent: true);
            }
        }

        //generate
        private void button1_Click(object sender, EventArgs e)
        {             
            var dodatoc4Model = PrepareModel();
            _dodatoc4Generator.Generate(dodatoc4Model);
        }    
      
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (KeyValuePair<int, string>)comboBox1.SelectedItem;
            var dodatoc4 = _dodatoc4Service.GetById(item.Key);

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
                Type type = typeof(Dodatoc4);

                foreach (var property in type.GetProperties().OrderBy(x => x.Name))
                {
                    PropertyInfo piShared = type.GetProperty(property.Name);
                    var control = this.Controls.Find(property.Name, true).FirstOrDefault();
                    control.Text = "";
                }
            }
        }

        private void LoadComboBox(bool selectedLast = false, bool selectedCurrent = false) 
        {
            var temp = comboBox1?.SelectedIndex;
            var source = _dodatoc4Service.GetAll().Select(x => new { Key = x.Id, Value = x.Id.ToString() + "; " + x.Input_1_орган_управління_освітою + "; " + x.Input_2_дата_час_нещасності }).ToList();

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

        private Dodatoc4 PrepareModel()
        {
            var model = new Dodatoc4();
            FormHelper.InputsToModel(this, model);

            return model;
        }
    }
}
