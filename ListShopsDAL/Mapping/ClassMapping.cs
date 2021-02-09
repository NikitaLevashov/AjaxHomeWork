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
        public static IEnumerable<Shop> MapToIEnumerableBLLShop(IEnumerable<Shop> shopsDAL)
        {
            var configMapper = new MapperConfiguration(cfg => cfg.CreateMap<Shop, Shop>());
            var mapper = new Mapper(configMapper);

            var shopsBLL = mapper.Map<IEnumerable<Shop>, IEnumerable<Shop>>(shopsDAL);

            return shopsBLL;
        }

    }
}
