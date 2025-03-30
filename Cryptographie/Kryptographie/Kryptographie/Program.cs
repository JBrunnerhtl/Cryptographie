
using System.Net;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

using Kryptographie;

class Program
{
    public static readonly List<string> Options = new List<string>() {"Ja", "Nein"};
    public static readonly Generator Generator = new();
    static void Main(string[] args)
    {
        Console.WriteLine("Hallo Willkommen bei der Kryptographie");
        var user = Login.GetLogin();
        if (!Login.CheckIfLoginWasCorrect(user)) // Check if the login was correct
        {
            user = Login.GetLogin();
        }
        
        
        
        Console.Clear();
        Console.WriteLine("Hallo " + user.Username + " was möchtest du tun[1=Verschlüsseln, 2=Entschlüsseln]");
        int action;
        bool isValid = false;
        do
        {
            isValid = int.TryParse(Console.ReadLine(), out action);
            if (!isValid)
            {
                Console.WriteLine("Bitte gebe eine Zahl ein[1, 2]");
            }

        } while (!isValid);
        
        



    }

    
}