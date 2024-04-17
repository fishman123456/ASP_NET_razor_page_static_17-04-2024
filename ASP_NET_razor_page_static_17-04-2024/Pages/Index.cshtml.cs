using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System;
using System.Diagnostics;

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ASP_NET_razor_page_static_17_04_2024.page
{
    public class IndexModel : PageModel
    {
        public int ServerStartTime
        {
            get
            {
                var st = Process.GetCurrentProcess().StartTime;
                var date = new DateTime(DateTime.Now.Year + 1, 1, 1);
                var span = date - DateTime.Now;
                int days = span.Days;
                return days;
            }
        }
        public void OnGet()
        {
        }
    }
}
