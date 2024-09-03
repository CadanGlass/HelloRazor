using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace HelloRazor.Pages
{
    public class ProcessModel : PageModel 
    {
        public void OnGet() {
            var procs = Process.GetProcesses();  // Get all processes
            ViewData["Procs"] = procs;           // Store them in ViewData
        }
    }
}
