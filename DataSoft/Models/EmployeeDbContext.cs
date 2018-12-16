using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DataSoft.Models
{
    public class EmployeeDbContext:DbContext
    {
        

        public System.Data.Entity.DbSet<DataSoft.Models.Employee> Employee { get; set; }
    }
   
}