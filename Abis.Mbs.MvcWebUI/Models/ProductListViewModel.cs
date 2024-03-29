﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abis.Mbs.Entities.Concrete;

namespace Abis.Mbs.MvcWebUI.Models
{
    public class ProductListViewModel
    {
        public int CurrentCategory { get; internal set; }
        public int CurrentPage { get; internal set; }
        public int PageCount { get; internal set; }
        public int PageSize { get; internal set; }
        public List<Product> Products { get; internal set; }
    }
}
