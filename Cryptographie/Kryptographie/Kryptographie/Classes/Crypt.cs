namespace Kryptographie;

public sealed class Crypt : ICrypt
{
    private string _code { get; set; } = "";
    public string Ascii { get; } // Get the Ascii table
    
    public Crypt()
    {
        for (int i = 32; i < 126; i++)
        {
            Ascii += (char)i;
        }
    }
    
   
}