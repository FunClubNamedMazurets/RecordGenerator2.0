using Domain.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Generators
{
    public class FormaNpvGenerator : BaseGenerator, IGenerator<FormaNpv>
    {
        public FormaNpvGenerator(bool hasGrid) : base(hasGrid)
        {
            FilePath = Environment.CurrentDirectory + @"\Templates\forma-npv.dotx";
        }
        public void Generate(FormaNpv model)
        {
            // to do; add check on model props not null
            ReadDocument();
            SetInputs(model);
        }
    }
}
