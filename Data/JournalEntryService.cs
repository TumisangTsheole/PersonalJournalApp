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
			},

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

		public JournalEntry GetEntry(int Id)
		{
			for (int i = 0; i<entries.Count; i++)
				{
					if (entries[i].Id == Id)
					{
						return entries[i];
					}
				}
			return null;	
		}

		public void AddEntry(JournalEntry Entry)
		{
			entries.Add(Entry);	
		}

		public void RemoveEntry(int Id)
		{
		
			for (int i = 0; i<entries.Count; i++)
			{
				if (entries[i].Id == Id)
				{
					entries.RemoveAt(i);
					break;
				}
			}
		}

		public void ModifyEntry(int Id, JournalEntry Entry)
		{
			RemoveEntry(Id);
			AddEntry(Entry);
		}

		
	}	
}
