using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ChineseZodiac.Models;  

namespace HelloRazor.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Year { get; set; }

        public string ZodiacSign { get; set; }

        public void OnGet()
        {
            
        }

        public void OnPost()
        {
            if (int.TryParse(Year, out int year) && year >= 1900 && year <= DateTime.Now.Year +1 )
            {
                ZodiacSign = Utils.GetZodiac(year);  // Calling the method from Utils
            }
            else
            {
                ZodiacSign = "Invalid year input.";
            }
        }
    }
}
