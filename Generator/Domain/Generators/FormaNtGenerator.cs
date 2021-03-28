using Domain.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Generators
{
    public class FormaNtGenerator : BaseGenerator, IGenerator<FormaNt>
    {
        public FormaNtGenerator(bool hasGrid = true) : base(hasGrid)
        {
            FilePath = Environment.CurrentDirectory + @"\Templates\forma-nt.dotx";
        }
        public void Generate(FormaNt model)
        {
            // to do; add check on model props not null
            ReadDocument();
            SetInputs(model);
        }
    }
}
