using Domain.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Generators
{
    public class Forma7Generator : BaseGenerator, IGenerator<Forma7>
    {
        public Forma7Generator(bool hasGrid = false) : base(hasGrid)
        {
            FilePath = Environment.CurrentDirectory + @"\Templates\forma-7-tnv.dotx";
        }

        public void Generate(Forma7 model)
        {
            // to do; add check on model props not null
            ReadDocument();
            SetInputs(model);
        }
    }
}
