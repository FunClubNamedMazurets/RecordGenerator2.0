using Domain.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Generators
{
    public class FormaN1Generator : BaseGenerator, IGenerator<FormaN1>
    {
        public FormaN1Generator(bool hasGrid = true) : base(hasGrid)
        {
            FilePath = Environment.CurrentDirectory + @"\Templates\forma-n-1.dotx";
        }

        public void Generate(FormaN1 model)
        {
            // to do; add check on model props not null
            ReadDocument();
            SetInputs(model);
        }
    }
}
