using System;

public class PromptGenerator
{
    private List <string> _journalPrompts = new List<string>
    {
        "What am I grateful for today?",
        "How did I see the hand of the Lord in my life today?",
        "If I had one thing I could do over today, what would it be?",
        "What did the Lord teach me today? How can I apply it tomorrow?",
        "What was the happiest thought I had today?"
    };

    public string GeneratePrompt()
    {
        Random random = new Random();
        int randomInt = random.Next(0,5);

        return _journalPrompts[randomInt];
    }
}
