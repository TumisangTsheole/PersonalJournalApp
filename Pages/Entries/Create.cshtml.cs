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

		// Only used for modification/edit requests
		[BindProperty(SupportsGet = true)]
		public int modifyId { get; set; }
    	
		public CreateModel(JournalEntryService EntryService)
		{
			_journalEntryService = EntryService;
		}

		// This OnGet() is for modification/edit purposes
        public void OnGet()
        {
        	// Get the entry/class at the specified 'Id' to display
        	// the current value of the 'entry'/class at bottom of page
			// Once modifications are done, a POST/OnPost() will be ran
			// and 'entry' willbe made to 'null' to make room for the creation
			// of a  new 'entry'
			
			if (modifyId != null) // if modifyId is 'null' that means we weren't redirected to this page and therefore the user is not attempting to modify
			{
        		entry = _journalEntryService.GetEntry(modifyId);
			}
        	
        	//Console.WriteLine($"The Id sent over by modify is -> {modifyId} ");
        }
        
        public void OnPost()
        {
        	// Delete the original 'entry' if user is attempting modification
        	if (modifyId != null)
        	{
				_journalEntryService.RemoveEntry(modifyId);	        		
        	}
        	
        	// Empty/Nullify 'entry' property
        	if (!string.IsNullOrEmpty(tags))
			{
				entry.Tags =  tags.Split(',').ToList();
			}

			_journalEntryService.AddEntry(entry);

			

			
			
        }
    }
}
