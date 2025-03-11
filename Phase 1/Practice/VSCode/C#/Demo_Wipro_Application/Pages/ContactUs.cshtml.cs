using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Demo_Wipro_Application.Pages
{
    public class ContactUs : PageModel
    {
        private readonly ILogger<ContactUs> _logger;

        public ContactUs(ILogger<ContactUs> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}