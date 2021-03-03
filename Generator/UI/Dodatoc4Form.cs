using Domain.Data.Entities;
using Domain.Generators;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Dodatoc4Form : Form
    {
        private readonly IGenerator<Dodatoc4> _dodatoc4Generator;
        private readonly Dodatoc4Service _dodatoc4Service;
        public Dodatoc4Form()
        {
            InitializeComponent();
            _dodatoc4Generator = new Dodatoc4Generator("dodatok4");
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

            if (string.IsNullOrEmpty(label1.Text) || label1.Text == "0")
            {
                _dodatoc4Service.Insert(dodatoc4Model);
                label1.Text = dodatoc4Model?.Id.ToString();
                LoadComboBox(selectedCurrent: true);                                             
            }
            else 
            { 
                _dodatoc4Service.Update(dodatoc4Model);             
                LoadComboBox(selectedLast: true);              
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

            label1.Text = dodatoc4?.Id.ToString();
            textBox3.Text = dodatoc4?.NameOfOrganAndAddress;
            textBox4.Text = dodatoc4?.DateAndTime;
            textBox5.Text = dodatoc4?.NameOfOrganAndOwner;
            richTextBox1.Text = dodatoc4?.Place;
            textBox6.Text = dodatoc4?.Initials;
            richTextBox2.Text = dodatoc4?.TypeInjuries;
            richTextBox3.Text = dodatoc4?.CausesAccident;
            textBox7.Text = dodatoc4?.DateAndSurname;
        }

        private void LoadComboBox(bool selectedLast = false, bool selectedCurrent = false) 
        {
            var temp = comboBox1?.SelectedIndex;
            var source = _dodatoc4Service.GetAll().Select(x => new { Key = x.Id, Value = x.Id.ToString() + "; " + x.NameOfOrganAndAddress + "; " + x.DateAndTime }).ToList();

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
            return new Dodatoc4()
            {
                //Id = Convert.ToInt32(label1.Text),
                NameOfOrganAndAddress = textBox3.Text,
                DateAndTime = textBox4.Text,
                NameOfOrganAndOwner = textBox5.Text,
                Place = richTextBox1.Text,
                Initials = textBox6.Text,
                TypeInjuries = richTextBox2.Text,
                CausesAccident = richTextBox3.Text,
                DateAndSurname = textBox7.Text
            };
        }
    }
}
