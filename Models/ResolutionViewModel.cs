using System;
using ASP.Models;
namespace ASP.Models
{
    public class ResolutionViewModel
    {
        public class ResolutionModel 
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public DateTime DateOfAdopting { get; set; }
            public string ResolutionFilePath { get; set; }
        }
    }
}