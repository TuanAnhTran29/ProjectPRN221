using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectPRN_RestaurantManagement.Models;

namespace ProjectPRN_RestaurantManagement.Pages.Account
{
    public class LoginModel : PageModel
    {

        private readonly RestaurantManagementContext context;
        [BindProperty]
        public LoginModel Input { get; set; }

        public LoginModel(RestaurantManagementContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
        }

        public void OnPost() {
            
        }

    }
}
