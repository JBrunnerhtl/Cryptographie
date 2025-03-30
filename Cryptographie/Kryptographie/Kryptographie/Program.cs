
using System.Net;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Text.Json;
using Kryptographie;

class Program
{
    public static readonly List<string> Options = new List<string>() {"Ja", "Nein"};
    public static Generator Generator = new();
    static void Main(string[] args)
    {
        Console.WriteLine("Hallo Willkommen bei der Kryptographie");
        var user = Login.GetLogin();
        Console.WriteLine(Login.CheckIfLoginWasCorrect(user));
        
        

    }

    
}