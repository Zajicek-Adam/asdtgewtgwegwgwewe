﻿using KOKOTDVA.Data;
using KOKOTDVA.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Net.Mime;

namespace KOKOTDVA.Pages
{
    public class IndexModel : PageModel
    {
        public IndexModel()
        {

        }
        public IActionResult OnGet()
        {
            if(User.Identity.IsAuthenticated)
            {
                return RedirectToPage("/Browse");
            }
            return Page();
        }
    }
}
