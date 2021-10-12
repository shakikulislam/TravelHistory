using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TravelHistory.Models;

namespace TravelHistory.DatabaseContext
{
    public class TravelHistoryDbContext : DbContext
    {
        public DbSet<PassportType> PassportTypes { get; set; }
    }
}