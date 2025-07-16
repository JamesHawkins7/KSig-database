using System;
    
namespace KSig_Grade_Tracker.Managers;

public class HomeManager
{
    /**
     * Prints "KSIG GRADES" and options to the terminal
     */
    public static void LoadHomeMenu()
    {
        Console.WriteLine("_  ______ ___ ____    ____ ____       _    ____  _____ ____  ");
        Console.WriteLine("| |/ / ___|_ _/ ___|  / ___|  _ \\     / \\  |  _ \\| ____/ ___| ");
        Console.WriteLine("| ' /\\___ \\| | |  _  | |  _| |_)  |  / _ \\ | | | |  _| \\___ \\ ");
        Console.WriteLine("| . \\ ___) | | |_| | | |_| |  _ <   / ___ \\| |_| | |___ ___) |");
        Console.WriteLine("|_|\\_\\____/___\\____|  \\____|_|  \\_\\/_/   \\_\\____/|_____|____/ ");
        Console.WriteLine("");
        Console.WriteLine("Please select an option:");
        Console.WriteLine("1. Add Student");
    }
    
}