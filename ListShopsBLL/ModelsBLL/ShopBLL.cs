using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListShopsBLL.ModelsBLL
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OperatingMode { get; set; }
        public string Description { get; set; }
    }
}
