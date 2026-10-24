using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("2 Nephi", "25", "26");

        Scripture scripture1 = new Scripture(
            reference1,
            "And we talk of Christ, we rejoice in Christ, we preach of Christ, " +
            "we prophesy of Christ, and we write according to our prophecies that " +
            "our children may know to what source they may look for a remission of " +
            "their sins."
        );

        Reference reference2 = new Reference("Moroni", "10", "4","5");

        Scripture scripture2 = new Scripture(
            reference2,
            "And when ye shall receive these things, I would exhort you that ye " +
            "would ask God, the Eternal Father, in the name of Christ, if these " +
            "things are not true; and if ye shall ask with a sincere heart, with " +
            "real intent, having faith in Christ, he will manifest the truth of " +
            "it unto you, by the power of the Holy Ghost."
        );

        Reference reference3 = new Reference("1 Nephi", "1", "20");

        Scripture scripture3 = new Scripture(
            reference3,
            "And when the Jews heard these things they wer angry with him; yea, even "+
            "as with the prophets of old, whom they had cast out, and stoned, and slain; "+
            "and they also sought his life, that they might take it away. But behold, "+
            "I, Nephi, will show unto you that the tender mercies of the Lord are over "+
            "all those whom he hath chosen, because of their faith, to make them mighty "+
            "even unto the power of deliverance."
        );
// Exceeds requirements addition: Added a scripture bank that allows the user to pick from 3 scriptures as opposed to only 1.

        ScriptureBank scriptureBank = new ScriptureBank([scripture1, scripture2, scripture3]); 

        Random random = new Random();

        int scriptureSelection = scriptureBank.GetScriptureChoice();
        Scripture currentScripture = scriptureBank.GetScripture(scriptureSelection);
        bool quitStatus = false;
        do
        {
            Console.Clear();
            Console.WriteLine(currentScripture.GetDisplayScripture());
            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit.");

            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                quitStatus = true;
            }

            else
            {
                int wordsToHide = random.Next(1,3);
                for (int i = 0; i < wordsToHide; i++)
                {
                    currentScripture.HideWord();
                }
            }
        } while(quitStatus == false && !currentScripture.IsAllHidden());

        Console.Clear();
        Console.WriteLine(currentScripture.GetDisplayScripture());
    }
}