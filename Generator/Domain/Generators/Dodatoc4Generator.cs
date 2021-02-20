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
            source = @"C:\Users\monst\Desktop\ZvitProcesor\Templates\dodatok4.dotx";
        }

        public void Generate(int id)
        {
            throw new NotImplementedException();
        }

        public void Generate(Dodatoc4 model)
        {
            ReadDocument();

            //logic of insert
            range = bookmarks[3].Range;
            range.Text = model.NameOfOrganAndAddress;

            CloseDocument();
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
