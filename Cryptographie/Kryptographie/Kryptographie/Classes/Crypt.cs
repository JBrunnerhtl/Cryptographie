namespace Kryptographie;

public sealed class Crypt : ICrypt
{
    private string _code { get; set; } = "";
    public string Ascii { get; } = ""; // Get the Ascii table
    
    public Crypt()
    {
        for (int i = 32; i < 126; i++)
        {
            Ascii += (char)i;
        }
        
    }

    public void CryptText(string text, User user)
    {
        GetCryptCode(user);

        char[] charText = text.ToCharArray();
        for (int i = 0; i < text.Length; i++)
        {
            charText[i] = _code[charText[i]];
        }
        File.WriteAllText("output.txt", charText.ToString());
        
    }

    private void GetCryptCode(User user)
    {
        if (!File.Exists("db.txt"))
        {
            throw new Exception("Database does not exist");
        }
        
        var lines = File.ReadAllLines("db.txt");
        lines = lines[1..];
        foreach (var dataLine in lines)
        {
            var data = dataLine.Split(";");
            if (data[0] == user.Username && data[1] == user.Password)
            {
                _code = data[2];
            }
        }
    }
    
   
}