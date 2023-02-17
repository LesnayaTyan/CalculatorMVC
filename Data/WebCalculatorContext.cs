using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebCalculator.Models;

namespace WebCalculator.Data
{
    public class WebCalculatorContext : DbContext
    {
        public WebCalculatorContext (DbContextOptions<WebCalculatorContext> options)
            : base(options)
        {
        }

        public DbSet<WebCalculator.Models.Calculator> Calculator { get; set; } = default!;
        //public DbSet<ExceptionLogger> ExceptionLoggers { get; set; }
 
    }
}
