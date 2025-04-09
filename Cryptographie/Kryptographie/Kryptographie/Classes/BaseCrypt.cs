namespace Kryptographie;

public abstract class BaseCrypt : ICrypt
{
    protected string _code; 
    public string Ascii { get; }

    protected BaseCrypt()
    {
        for (int i = 32; i < 126; i++)
        {
            Ascii += (char)i;
        }
    }
    
    protected void GetCryptCode(User user)
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