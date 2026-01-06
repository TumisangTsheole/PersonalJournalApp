using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalJournalApp.Data;
using PersonalJournalApp.Models;

namespace PersonalJournalApp.Pages.Entries
{
    public class ViewModel : PageModel
    {	
    	
		private readonly JournalEntryService journalEntryService;

		// Store for single entry
		public JournalEntry entry { get; set; }
		
		// Set via Index page redirection when user wishes to view 'Entry'
		[BindProperty(SupportsGet = true)]
		public int viewId { get; set; }

		public ViewModel(JournalEntryService EntryService)
		{
			journalEntryService = EntryService;
		}
		
        public void OnGet()
        {
        	entry = journalEntryService.GetEntry(viewId);
        }
    }
}
