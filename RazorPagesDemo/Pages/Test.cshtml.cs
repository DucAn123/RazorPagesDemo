using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesDemo.Pages
{
    public class TestModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
        }
    }
}
