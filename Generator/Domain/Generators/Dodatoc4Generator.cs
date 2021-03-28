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
        public Dodatoc4Generator(bool hasGrid = false) : base(hasGrid)
        {
            FilePath = Environment.CurrentDirectory + @"\Templates\Dodatok-4.dotx";
        }

        public void Generate(Dodatoc4 model)
        {
            // to do; add check on model props not null
            ReadDocument();
            SetInputs(model);
        }
    }
}
