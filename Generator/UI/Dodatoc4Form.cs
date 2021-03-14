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
            //LoadComboBox();
        }

        //save form to db
        private void button2_Click(object sender, EventArgs e)
        {
            var dodatoc4Model = PrepareModel();

            if (string.IsNullOrEmpty(label1.Text) || label1.Text == "0")
            {
                _dodatoc4Service.Insert(dodatoc4Model);
                label1.Text = dodatoc4Model?.Id.ToString();
                //LoadComboBox(selectedCurrent: true);                                             
            }
            else 
            { 
                _dodatoc4Service.Update(dodatoc4Model);             
                //LoadComboBox(selectedLast: true);              
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
            textBox3.Text = dodatoc4?.Input_1_Education_Management;
            textBox4.Text = dodatoc4?.Input_2_Date_Of_Accident;
            textBox5.Text = dodatoc4?.Input_3_Name_Of_School_And_Creator;
            richTextBox1.Text = dodatoc4?.Input_4_Place_Of_Accident;
            textBox6.Text = dodatoc4?.Input_5_Poor_Ones;
            richTextBox2.Text = dodatoc4?.Input_6_Trauma;
            richTextBox3.Text = dodatoc4?.Input_7_Reasons_Of_Accident;
            textBox7.Text = dodatoc4?.Input_8_Date_And_Surname;
        }

        private void LoadComboBox(bool selectedLast = false, bool selectedCurrent = false) 
        {
            var temp = comboBox1?.SelectedIndex;
            var source = _dodatoc4Service.GetAll().Select(x => new { Key = x.Id, Value = x.Id.ToString() + "; " + x.Input_1_Education_Management + "; " + x.Input_2_Date_Of_Accident }).ToList();

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
                Input_1_Education_Management = textBox3.Text,
                Input_2_Date_Of_Accident = textBox4.Text,
                Input_3_Name_Of_School_And_Creator = textBox5.Text,
                Input_4_Place_Of_Accident = richTextBox1.Text,
                Input_5_Poor_Ones = textBox6.Text,
                Input_6_Trauma = richTextBox2.Text,
                Input_7_Reasons_Of_Accident = richTextBox3.Text,
                Input_8_Date_And_Surname = textBox7.Text
            };
        }
    }
}
