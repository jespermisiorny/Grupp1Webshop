﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grupp1Webshop.Models;

namespace Grupp1Webshop.Models
{
    internal class Category
    {
        public Category()
        {
            NewProducts = new HashSet<NewProduct>();
        }
        public int? Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<NewProduct> NewProducts { get; set; }

    }
}
