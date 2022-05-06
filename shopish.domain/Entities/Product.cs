﻿using shopish.domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopish.domain.Entities
{
    public class Product : BaseEntity, IMustHaveTenant
    {
        public Product(string name, string description, int rate)
        {
            Name = name;
            Description = description;
            Rate = rate;
        }
        protected Product()
        {
        }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Rate { get; private set; }
        public string TenantId { get; set; }
    }
}
