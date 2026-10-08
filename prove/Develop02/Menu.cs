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
    5. Exit
    What would you like to do? 
    """;


    public void DisplayMenu()
    {
        Console.WriteLine(_menuOptions);
    }
    public string GetMenuSelection()
    {
        DisplayMenu();
        string  menuSelection = Console.ReadLine();

        return menuSelection;
    }


//     public void MenuActions()
//     {
//         Entry entry = new Entry();
//         string menuSelection;
//         do
//         {   
//             menuSelection = GetMenuSelection();

//             if (menuSelection == "1")
//             {
//                 entry.AddEntry();
//             }
//             else if (menuSelection == "2")
//             {
//                 entry.DisplayAllEntries();
//             }
//             else if (menuSelection == "3")
//             {
                
//             }
//             else if (menuSelection == "4")
//             {
                
//             }
//         }while (int.Parse(menuSelection) <5);
//     }
}


    