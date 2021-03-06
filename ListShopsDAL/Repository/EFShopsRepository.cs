﻿using AutoMapper;
using ListShopsBLL.interfaces;
using ListShopsBLL.ModelsBLL;
using ListShopsDAL.EF;
using ListShopsDAL.Mapping;
using ListShopsDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListShopsDAL.Repository
{
    public class EFShopsRepository : IGetShopsRepository
    {
        private ShopsDBContext _context;
        public EFShopsRepository(ShopsDBContext shopDbContext)
        {
            _context = shopDbContext;
        }
        public IEnumerable<ShopDAL> ShopsDAL => _context.Shops;
        public IEnumerable<ShopBLL> ShopsBLL => ClassMapping.MapToIEnumerableBLLShop(ShopsDAL);
    }
}
