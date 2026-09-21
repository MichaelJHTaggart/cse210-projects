public class Entry
{
    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";

    public void Display()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        _promptText = promptGenerator.GetRandomPrompt();
        Console.WriteLine(_promptText);
        // Write a new entry - Show the user a random prompt From the PromptGenerator Class > GetRandomPrompt() function (which will grab from a list of prompts I create), and save their response, the prompt, and the date as an Entry.
    }
}