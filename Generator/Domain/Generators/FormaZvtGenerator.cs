using Domain.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Generators
{
    public class FormaZvtGenerator : BaseGenerator, IGenerator<FormaZvt>
    {
        public FormaZvtGenerator(bool hasGrid) : base(hasGrid)
        {
            FilePath = Environment.CurrentDirectory + @"\Templates\forma-zvt-t-2-za-20.dotx";
        }

        public void Generate(FormaZvt model)
        {
            // to do; add check on model props not null
            ReadDocument();
            SetInputs(model);
        }
    }
}
