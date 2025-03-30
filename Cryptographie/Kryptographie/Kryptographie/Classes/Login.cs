namespace Kryptographie;

public static class Login
{
    public static bool CheckIfLoginWasCorrect(User user) // If users has an account and the login was correct
    {
        if (!File.Exists("db.txt"))
        {
            throw new Exception("Database does not exist");
        }
        else
        {
            var lines = File.ReadAllLines("db.txt");
            lines = lines[1..];
            foreach (var dataLine in lines)
            {
                var data = dataLine.Split(";");
                if (data[0] == user.Username && data[1] == user.Password)
                {
                    return true;
                }
            }
        }

        Console.WriteLine("Du hast keinen Account");
        CreateAccount();
        return false;
    }

    private static void CreateAccount()
    {
        string username = "";
        string password = "";
        Console.WriteLine("Gebe bitte deinen gewünschten Namen ein");
        do
        {
            username = Console.ReadLine()!;
        } while (username == "");
        
        Console.WriteLine("Gebe bitte dein Passwort ein");
        do
        {
            password = Console.ReadLine()!;
        } while (password == "");

        string code = Program.Generator.GenerateCode();
        List<string> lines = File.ReadAllLines("db.txt").ToList();
        lines.Add($"{username};{password};{code}");
        File.WriteAllLines("db.txt", lines);
        
    }
    

    public static User GetLogin() // Get the login information
    {
       
        string anwser = "";
        string username = "";
        string password = "";
        
        
        
        Console.WriteLine("Hast du schon ein Konto? (Ja/Nein)");
        do
        {
            anwser = Console.ReadLine();
            if(anwser != null || !Program.Options.Contains(anwser!))
            {
                Console.WriteLine("Bitte gebe Ja oder Nein ein");
            }
        } while (!Program.Options.Contains(anwser!));
        Console.Clear();
        if(anwser == Program.Options[1])
        {
            CreateAccount();
            Console.Clear();
        }
        
        
        Console.WriteLine("Gebe bitte deinen Benutzernamen ein");
        do
        {
            username = Console.ReadLine()!;
        } while (username == "");
        
        Console.WriteLine("Gebe bitte dein Passwort ein");
        do
        {
            password = Console.ReadLine()!;
        } while (password == "");
        
        return new User(username, password, anwser == "Ja" ? true : false);
    }
}