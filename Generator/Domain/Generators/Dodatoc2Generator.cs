using Domain.Data.Entities;
using Domain.Services;
using System;
using System.Xml.Linq;

namespace Domain.Generators
{
    public class Dodatoc2Generator : BaseGenerator, IGenerator<Dodatoc2>
    {
        private Dodatoc2Service dodatoc2Service;

        public Dodatoc2Generator(string path) : base(path)
        {
            dodatoc2Service = new Dodatoc2Service();
           
        }

        public bool Validate(Dodatoc2 model) 
        {
            if (model == null)
            {
                return false;
            }

            return true;
        }

        public void Save(Dodatoc2 model)
        {
            dodatoc2Service.Insert(model);
        }

        public void Generate()
        {
            //var model =  dodatoc2Service.GetById(id);
            //DocumentCore documentCore = new DocumentCore();
            //documentCore.Content.End.Insert("test");
            //documentCore.Save("test1.docx");

            //System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("test1.docx"));

            //DocX doc = DocX.Create(pathForSave);
            //doc.MarginTop = 400;

            //Paragraph paragraph = doc.InsertParagraph();

            //paragraph.Alignment = Alignment.right;
            //doc.InsertParagraph(paragraph);
            //doc.MarginTop = 400;
            //paragraph.Alignment = Alignment.left;
            //doc.InsertParagraph(paragraph);

            //doc.Save();

            //System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(pathForSave));

        }

        public void Generate(int id)
        {
            throw new NotImplementedException();
        }

        public void Generate(Dodatoc2 model)
        {
            throw new NotImplementedException();
        }
    }
}
