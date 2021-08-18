using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TucDemo.Models;

namespace TucDemo.Pages
{
    public class SuppliersModel : PageModel
    {
        private readonly NorthwindContext _context;

        public SuppliersModel(NorthwindContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            SuppliersToShow = _context.Suppliers.Where(e => e.Country == "UK"
                                                         || e.Country == "USA").ToList();

            Day = DateTime.Now.DayOfWeek;
        }

        public List<Supplier> SuppliersToShow { get; set; }
        public DayOfWeek Day { get; set; }
    }
}
