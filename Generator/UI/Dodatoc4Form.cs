using Domain.Data.Entities;
using Domain.Generators;
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
        private IGenerator<Dodatoc4> _dodatoc4Generator;
        public Dodatoc4Form()
        {
            InitializeComponent();
            _dodatoc4Generator = new Dodatoc4Generator("dodatok4");
        }

        //save form to db
        private void button2_Click(object sender, EventArgs e)
        {
            var dodatoc4Model = PrepareModel();

            _dodatoc4Generator.Save(dodatoc4Model);
        }

        //generate
        private void button1_Click(object sender, EventArgs e)
        {
            var dodatoc4Model = PrepareModel();


            _dodatoc4Generator.Generate(dodatoc4Model);
        }

        private Dodatoc4 PrepareModel() 
        {
            return new Dodatoc4()
            {
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
