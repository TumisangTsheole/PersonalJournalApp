using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalJournalApp.Data;
using PersonalJournalApp.Models;

namespace PersonalJournalApp.Pages.Entries
{
    public class ModifyModel : PageModel
    {
		public readonly JournalEntryService journalEntryService;
		public JournalEntry existingEntry { get; set; }
    
    	[BindProperty(SupportsGet = true)]
    	public required int Id { get; set; }
    	
		public ModifyModel(JournalEntryService EntryService)
		{
			journalEntryService = EntryService;
		}

        public IActionResult OnGet()
        {
        	return RedirectToPage("/Entries/Create", new { modifyId = Id });
        }
    }
}
