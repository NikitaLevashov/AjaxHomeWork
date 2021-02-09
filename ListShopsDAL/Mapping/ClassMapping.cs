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
        public static IEnumerable<ShopBLL> MapToIEnumerableBLLShop(IEnumerable<ShopDAL> shopsDAL)
        {
            var configMapper = new MapperConfiguration(cfg => cfg.CreateMap<ShopDAL, ShopBLL>());
            var mapper = new Mapper(configMapper);

            var shopsBLL = mapper.Map<IEnumerable<ShopDAL>, IEnumerable<ShopBLL>>(shopsDAL);

            return shopsBLL;
        }

    }
}
