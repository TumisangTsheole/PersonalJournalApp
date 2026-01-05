using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalJournalApp.Models;
using PersonalJournalApp.Data;

namespace PersonalJournalApp.Pages.Entries
{
    public class IndexModel : PageModel
    {
    	// Properties to be displayed on page
    	private readonly JournalEntryService _journalEntryService;	
		public JournalEntry entries { get; set; }


    	// Constructor Injection
		public IndexModel(JournalEntryService EntryService)
		{
			_journalEntryService = EntryService;
		}

        public void OnGet()
        {
        	entries = _journalEntryService.entries;
        }
    }
}
