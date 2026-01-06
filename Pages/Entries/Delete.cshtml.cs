using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalJournalApp.Data;
using PersonalJournalApp.Models;

namespace PersonalJournalApp.Pages.Entries
{
    public class DeleteModel : PageModel
    {
		[BindProperty(SupportsGet = true)]
		public  int RemoveId { get; set; }
    
		public readonly JournalEntryService journalEntryService;

		public DeleteModel(JournalEntryService EntryService)
		{
			journalEntryService = EntryService;
		}

        public void OnGet()
        {
        	journalEntryService.RemoveEntry(RemoveId);
        }
    }
}
