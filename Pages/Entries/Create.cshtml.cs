using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalJournalApp.Models;
using PersonalJournalApp.Data;

namespace PersonalJournalApp.Pages.Entries
{
    public class CreateModel : PageModel
    {
		public readonly JournalEntryService _journalEntryService;

		[BindProperty]
		public required JournalEntry entry { get; set; }
		[BindProperty]
		public string? tags { get; set; }
    	
		public CreateModel(JournalEntryService EntryService)
		{
			_journalEntryService = EntryService;
		}

        public void OnGet()
        {
        }
        
        public void OnPost()
        {
        	if (!string.IsNullOrEmpty(tags))
			{
				entry.Tags =  tags.Split(',').ToList();
			}

			_journalEntryService.AddEntry(entry);
			
        }
    }
}
