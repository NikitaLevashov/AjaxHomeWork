﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ListShopsBLL.ModelsBLL;

namespace ListShopsBLL.interfaces
{
    public interface IGetShopsRepository
    {
        public IEnumerable<ShopBLL> ShopsBLL { get; }
    }
}
