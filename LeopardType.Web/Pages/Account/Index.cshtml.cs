using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LeopardType.Web.Pages.Account
{
    public class IndexModel : PageModel
    {
        public string aMessage { get; set; }

        public void OnGet()
        {
            aMessage = "this is my message";
        }
    }
}
