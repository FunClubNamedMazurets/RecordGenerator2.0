﻿using Domain.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Generators
{
    public interface IGenerator<T> where T : BaseEntity
    {
        void Generate(T model);
    }
}
