namespace Kryptographie;

public sealed class Crypt : BaseCrypt
{
    public void CryptText(string text, User user)
    {
        GetCryptCode(user);

        char[] charText = text.ToCharArray();
       
        for (int i = 0; i < text.Length; i++)
        {
            charText[i] = _code[charText[i]- 31];
        }

        string newString = "";
        foreach (char c in charText)
        {
            newString += c;
        }
        File.WriteAllText("output.txt", newString);
        
    }
    
   
}