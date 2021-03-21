using Domain.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Generators
{
    public class Dodatoc1Generator : BaseGenerator, IGenerator<Dodatoc1>
    {
        public Dodatoc1Generator(bool hasGrid = true) : base(hasGrid)
        {
            FilePath = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.Length - 12) + @"Domain\Templates\dodatok-1.dotx";
        }

        public void Generate(Dodatoc1 model)
        {
            ReadDocument();
            SetInputs(model);
        }
    }
}
