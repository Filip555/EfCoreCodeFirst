using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EfCodeFirst.EF
{
public class SomeContext : DbContext
{
    public DbSet<SomeTable> SomeTable { get; set; }
    public SomeContext(DbContextOptions<SomeContext> options) : base(options)
    {
    }
}
}
