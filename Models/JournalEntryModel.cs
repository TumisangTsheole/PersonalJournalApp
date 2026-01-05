namespace PersonalJournalApp.Models
{
	public class JournalEntry
	{
		public int? Id { get; set; }
		public string? Title { get; set; }
		public string? Content { get; set; }
		public DateOnly? Date { get; set; }
		public string? Mood { get; set; }
		public List<string>? Tags { get; set; }
		public bool? IsFavorite { get; set; }
	}
}
