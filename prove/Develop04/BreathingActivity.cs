using System;
using System.Threading.Tasks.Dataflow;

public class BreathingActivity : Activity
{
    private List<string> _circles = new List<string>
    {
    """
     **
    ****
    ****
     **
    """,

    """
      ****
     ******
    ********
    ********
     ******
      ****
    """,

    """
       ******
     **********
    ************
    ************
    ************
     **********
       ******
    """,

    """
        ********
      ************
     **************
    ****************
    ****************
    ****************
     **************
      ************
        ********
    """
    };

    public BreathingActivity()
    : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on breathing.")
    {
    }

    public void StartBreathingActivity()
    {
        StartActivity();
        Pause();
        StartTimer();
        while (Timer())
        {
            BreathAnimation();
        }
        DisplayFinishedMessage();
    }

    public void BreathAnimation()
    {
        foreach (string circle in _circles)
        {
            Console.Clear();
            Console.WriteLine(circle);
            Console.WriteLine("Breath In");
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine(_circles[3]);
        Console.WriteLine("Hold");
        Thread.Sleep(4000);

        for (int i = _circles.Count - 1; i >= 0; i--)
        {
            Console.Clear();
            Console.WriteLine(_circles[i]);
            Console.WriteLine("Breathe Out");
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine(_circles[0]);
        Console.WriteLine("Hold");
        Thread.Sleep(4000);
    }
}
