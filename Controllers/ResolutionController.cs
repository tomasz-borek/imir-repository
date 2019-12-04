using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace ASP.Controllers
{
    public class ResolutionController : Controller
    {
        private readonly ResolutionContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public ResolutionController(ResolutionContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            this._hostingEnvironment = hostingEnvironment;
        }
        public IActionResult ShowAll()
        {
            return View(_context.Resolutions.ToList());
        }

        [HttpGet]
        public IActionResult AddResolution()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult AddResolution(string name, string description, DateTime dateOfAdopting, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                string filePath = null;
                if (file != null)
                {
                    string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "resolutions");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                    filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    file.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                Resolution resolution = new Resolution();
                resolution.Name = name;
                resolution.Description = description;
                resolution.DateOfAdopting = dateOfAdopting;
                resolution.ResolutionFilePath = filePath;

                _context.Resolutions.Add(resolution);

                _context.SaveChanges();
            
                return RedirectToAction("Index","Home");
            }
            else
            {
            return View("AddResolution");
            }
        }
    }

}
