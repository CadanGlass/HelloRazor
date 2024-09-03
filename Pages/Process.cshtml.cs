using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;


namespace HelloRazor.Pages
{
    public class ProcessModel : PageModel 
    {
        public void OnGet() {
            var Procs = Process.GetCurrentProcess();
            ViewData["Procs"] = Procs;
        }
    }
}
