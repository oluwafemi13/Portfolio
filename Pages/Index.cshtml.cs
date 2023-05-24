using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Portfolio.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private InputModel input;

        public class InputModel
        {
            public string Subject { get; set; }
            public string Body { get; set; }
            public string Email { get; set; }
            public string Name { get; set; }
        }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void onPost()
        {
          //return Page();
        }
    }
}