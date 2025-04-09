namespace Kryptographie;

public sealed class Decrypt : BaseCrypt
{

    public void DecryptText(string text, User user)
    {
        GetCryptCode(user);

        for (int i = 0; i < _code.Length; i++)
        {
            text = text.Replace(Ascii[i], _code[i]);
        }
        File.WriteAllText("output.txt", text);
    }
    
    
    
}