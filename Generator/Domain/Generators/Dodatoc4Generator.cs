using Domain.Data.Entities;
using Domain.Services;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Generators
{
    public class Dodatoc4Generator : BaseGenerator, IGenerator<Dodatoc4>
    {      
        private Dodatoc4Service _dodatoc4Service;

        public Dodatoc4Generator(string path) : base(path)
        {
            _dodatoc4Service = new Dodatoc4Service();
            source = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.Length - 12) + @"Domain\Templates\"+ path +".dotx";
        }

        public void Generate(int id)
        {
            throw new NotImplementedException();
        }

        public void Generate(Dodatoc4 model)
        {
            ReadDocument();
            //logic of insert
            range = bookmarks[0].Range;
            range.Text = model.DateAndSurname;

            range = bookmarks[1].Range;
            range.Text = model.DateAndTime;

            range = bookmarks[2].Range;
            range.Text = model.NameOfOrganAndAddress;

            range = bookmarks[3].Range;
            range.Text = model.NameOfOrganAndOwner;

            range = bookmarks[4].Range;
            range.Text = model.Place;
    
            range = bookmarks[5].Range;
            range.Text = model.Initials;

            range = bookmarks[6].Range;
            range.Text = model.CausesAccident;

            range = bookmarks[7].Range;
            range.Text = model.TypeInjuries;



            // CloseDocument();
        }

        public void Save(Dodatoc4 model)
        {
            _dodatoc4Service.Insert(model);
        }

        public bool Validate(Dodatoc4 model)
        {
            if (model == null)
            {
                return false;
            }

            return true;
        }
    }
}
