namespace Kryptographie;

public sealed class Crypt : BaseCrypt
{
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
    
   
}