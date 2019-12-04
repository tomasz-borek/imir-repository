using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace ASP.Models
{
    public class ResolutionContext : DbContext
    {
        public ResolutionContext(DbContextOptions<ResolutionContext> options) : base(options)
        {
        }
        public DbSet<Resolution> Resolutions { get; set; }
    }

    public class Resolution
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ResolutionFilePath { get; set; }
        public DateTime DateOfAdopting { get; set; }
    }
}