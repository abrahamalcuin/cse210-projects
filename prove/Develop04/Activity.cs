using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

public class Activity
{
    private string _activityName;
    private string _activityDescription;
    private int _activityDuration;
    private int _pauseDuration = 2;
    private DateTime _endTime;
    private List<string> _pauseAnimationSymbols = ["|", "/", "—", "\\", "|", "/", "|"];

    private Stopwatch _stopwatch = new Stopwatch();

    public Activity(string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}.\n\n{_activityDescription}");
    }

    public void DisplayFinishedMessage()
    {
        Console.WriteLine("\nWell Done!!");
        Console.WriteLine($"\nYou have completed another {_activityDuration} seconds of the {_activityName}");
    }

    public void PromptForDuration()
    {
        Console.WriteLine("\nHow many seconds would you like your session to be?");
        _activityDuration = int.Parse(Console.ReadLine());
    }
    
    public void Pause()
    {
        PauseAnimation();
    }

    public void SetPauseDuration(int duration)
    {
        _pauseDuration = duration;
    }

    public void StartTimer()
    {
        _endTime = DateTime.Now.AddSeconds(_activityDuration);
    }

    public bool Timer()
    {
        return DateTime.Now < _endTime;
    }

    public void PauseAnimation()
    {
        _stopwatch.Restart();
        while (_stopwatch.Elapsed.TotalSeconds < _pauseDuration)
        {
            foreach (string pauseAnimationSymbol in _pauseAnimationSymbols)
            {
                if (_stopwatch.Elapsed.TotalSeconds >= _pauseDuration)
                {
                    break;
                }
                Console.Write(pauseAnimationSymbol);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
        _stopwatch.Stop();
    }

    public void PauseAnimation2()
    {
        for (int i = _pauseDuration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void StartActivity()
    {
        Console.Clear();
        DisplayStartMessage();
        PromptForDuration();
        Console.Write("Get Ready...");
    }
}
