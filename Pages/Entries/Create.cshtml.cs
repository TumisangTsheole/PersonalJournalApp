using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalJournalApp.Models;

namespace PersonalJournalApp.Pages.Entries
{
    public class CreateModel : PageModel
    {
		[BindProperty]
		public required JournalEntry entry { get; set; }
		[BindProperty]
		public string? moodTags { get; set; }
    	
        public void OnGet()
        {
        }
        
        public void OnPost()
        {
        	Console.WriteLine($"Entry Id: {entry.Id}\nEntry Title: {entry.Title}");
			entry.Tags = new List<string>{"happy", "sad"};
        }
    }
}
