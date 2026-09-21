public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        // Call Entry Class > Display() function
    }

    public void DisplayAll()
    {
        // Display the journal - Iterate through all entries in the journal and display them to the screen.
    }

    public void SaveToFile(string file)
    {
        // Save the journal to a file - Prompt the user for a filename and then save the current journal (the complete list of entries) to that file location.
    }

    public void LoadFromFile(string file)
    {
        // Load the journal from a file - Prompt the user for a filename and then load the journal (a complete list of entries) from that file. This should replace any entries currently stored the journal.

    }
}