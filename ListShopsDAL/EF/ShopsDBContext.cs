using ListShopsBLL.ModelsBLL;
using ListShopsDAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListShopsDAL.EF
{
    public class ShopsDBContext : DbContext
    {
        public ShopsDBContext(DbContextOptions<ShopsDBContext> options) : base(options)
        {

        }

        public DbSet<Shop> Shops { get; set; }
    }
}
