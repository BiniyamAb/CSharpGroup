using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharpGroup.Pages
{
    public class AuthOptionModel : PageModel
    {
        public int providerId = 0;
        public void OnGet(int providerId)
        {
            this.providerId = providerId;
        }
    }
}
