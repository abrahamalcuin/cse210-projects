using System;

public class ListingActivity : Activity
{
    private List<string> _listingPrompts;

    private Random _random = new Random();
    private int _count;

    public ListingActivity(List<string> listingPrompts)
    : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _listingPrompts = listingPrompts;
    }

    public void StartListing()
    {
        _count = 0;
        StartActivity();
        Pause();
        PromptUser();
        Console.Write("You may begin in ");
        PauseAnimation2();
        StartTimer();
        UserListing();
        Console.WriteLine($"You listed {_count} items!! ");
        DisplayFinishedMessage();
    }

    public void PromptUser()
    {
        int promptIndex = _random.Next(_listingPrompts.Count);
        Console.WriteLine(_listingPrompts[promptIndex]);
    }

    public void UserListing()
    {
        while (Timer())
        {
            Console.WriteLine(" ");
            Console.ReadLine();
            _count += 1;

            if (!Timer())
            {
                break;
            }
        }
    }
}
