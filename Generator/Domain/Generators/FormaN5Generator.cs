using Domain.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Generators
{
    public class FormaN5Generator : BaseGenerator, IGenerator<FormaN5>
    {
        public FormaN5Generator(bool hasGrid) : base(hasGrid)
        {
            FilePath = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.Length - 12) + @"Domain\Templates\forma-n-5.dotx";
        }
        public void Generate(FormaN5 model)
        {
            // to do; add check on model props not null
            ReadDocument();
            SetInputs(model);
        }
    }
}
