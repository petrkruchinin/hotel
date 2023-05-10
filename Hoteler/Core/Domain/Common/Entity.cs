﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public class Entity
    {
        public Guid Id { get; }
        public Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
