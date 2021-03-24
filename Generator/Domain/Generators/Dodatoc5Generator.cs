using Domain.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Generators
{
    public class Dodatoc5Generator : BaseGenerator, IGenerator<Dodatoc5>
    {
        public Dodatoc5Generator(bool hasGrid = false) : base(hasGrid)
        {
            FilePath = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.Length - 12) + @"Domain\Templates\dodatok-5.dotx";
        }

        public void Generate(Dodatoc5 model)
        {
            // to do; add check on model props not null
            ReadDocument();
            SetInputs(model);
        }
    }
}
