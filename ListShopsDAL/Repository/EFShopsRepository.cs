using AutoMapper;
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
        public IQueryable<Shop> Shops => _context.Shops;
        IQueryable<ShopBLL> IGetShopsRepository.ShopsBLL => ClassMapping.MapToIQueryableBLLShop(Shops);

    }
}
