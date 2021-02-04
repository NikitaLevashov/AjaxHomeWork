using AutoMapper;
using ListShopsBLL.ModelsBLL;
using ListShopsDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ListShopsDAL.Mapping
{
    public static class ClassMapping
    {
        public static IQueryable<ShopBLL> MapToIQueryableBLLShop(this IQueryable<Shop> shop)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ShopBLL, Shop>()).CreateMapper();
            var shops = mapper.Map<IEnumerable<Shop>, IQueryable<ShopBLL>>(shop);
            return shops;
        }
        public static IQueryable<Shop> MapToIQueryableShop(this IQueryable<ShopBLL> shop)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Shop, ShopBLL>()).CreateMapper();
            var shops = mapper.Map<IEnumerable<ShopBLL>, IQueryable<Shop>>(shop);

            return shops;
        }

    }
}
