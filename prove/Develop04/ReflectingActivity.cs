using System;

public class ReflectingActivity : Activity
{
    private List<string> _questions;
    private List<string> _followUpQuestions;
    private Random _random = new Random();

    public ReflectingActivity(List<string> questions, List<string> followUpQuestions)
    : base("Reflecting Activity.",
            "This activity will help you reflect on times this week where you've felt stressed and help you understand what might have caused it.")
    {
        _questions = questions;
        _followUpQuestions = followUpQuestions;
    }

    public void StartReflection()
    {
        StartActivity();
        SetPauseDuration(5);
        DisplayQuestion();
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Write("You may begin in ");
        PauseAnimation2();
        SetPauseDuration(8);
        Console.Clear();
        StartTimer();
        while (Timer())
        {
            DisplayFollowUpQuestion();
            Pause();
        }
        DisplayFinishedMessage();
    }

    public void DisplayQuestion()
    {
        int randomQuestionIndex = _random.Next(_questions.Count);
        string randomQuestion = _questions[randomQuestionIndex];
        Console.WriteLine("\n Consider the following prompt:");
        Console.Write($"\n{randomQuestion} ");
    }

    public void DisplayFollowUpQuestion()
    {   
        int randomIndex = _random.Next(_followUpQuestions.Count);
        Console.Write($"\n{_followUpQuestions[randomIndex]} ");
    }
}
