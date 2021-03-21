using Domain.Data.Entities;
using Domain.Services;
using System;
using System.Xml.Linq;

namespace Domain.Generators
{
    public class Dodatoc2Generator : BaseGenerator, IGenerator<Dodatoc2>
    {
        public Dodatoc2Generator(bool hasGrid = true) : base(hasGrid)
        {
            FilePath = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.Length - 12) + @"Domain\Templates\dodatok-2.dotx";
        }

        public void Generate(Dodatoc2 model)
        {
            // to do; add check on model props not null
            ReadDocument();
            SetInputs(model);
        }
    }
}
