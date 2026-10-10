using System;

public class Menu
{
    private string _menuOptions =
    """

    Please select one of the following choices:
    1. Write
    2. Display
    3. Save
    4. Load
    5. Startup Settings
    6. Exit
    What would you like to do? 
    
    """;


    public void DisplayMenu()
    {
        Console.WriteLine(_menuOptions);
    }

    public string GetMenuSelection()
    {
        DisplayMenu();
        string menuSelection = Console.ReadLine();

        return menuSelection;
    }
}
