using PersonalJournalApp.Models;

namespace PersonalJournalApp.Data
{
	public class JournalEntryService
	{
		private List<JournalEntry> entries = new List<JournalEntry>{
			new JournalEntry{
				Id = 1,
				Title = "hello world",
				Content = "This is my new project",
				Date = new DateOnly(2026,1,1),
				Mood = "happy",
				Tags = new List<string>{"coding", "dotnet"},
				IsFavorite = true
			}
		};

		public List<JournalEntry> GetAllEntries()
		{
			return entries;
		}

		public void AddEntry(JournalEntry entry)
		{
			entries.Add(entry);	
		}

		public void RemoveEntry(int Id)
		{
			// TODO
		}

		public void ModifyEntry(int Id)
		{
			// TODO
		}

		
	}	
}
