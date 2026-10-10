using System;
public class StartupSettings
{
    private string _startupFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup),
    "Develop02Journal.cmd");

    private string _projectPath = @"C:\Users\abrah\OneDrive\Desktop\cse210-projects\prove\Develop02";

    public void TurnOnStartup()
    {
        File.WriteAllText(_startupFile, $"cd /d \"{_projectPath}\"\r\ndotnet run\r\n");
    }

    public void TurnOffStartup()
    {
        if (File.Exists(_startupFile))
        {
            File.Delete(_startupFile);
        }
    }

    public bool IsStartupEnabled()
    {
        return File.Exists(_startupFile);
    }
}
