using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sales.Domain.Models;

namespace Sales.BackEnd.Models
{
    public class LocalDataContext:DataContext
    {
        public System.Data.Entity.DbSet<Sales.Common.Models.Product> Products { get; set; }
    }
}