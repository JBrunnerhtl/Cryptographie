namespace Kryptographie;

public class Generator : IGenerator
{
    public Generator()
    {
        
    }
    public string GenerateCode()
    {
        int lenght = 94; 
        string code = ""; // The code that will be generated
        List<char> alreadyUsed = new(); // List of already used characters
        for (int i = 0; i < lenght; i+=0)
        {
            var randomNumber = Random.Shared.Next(31, 125);
            char letter = (char)randomNumber;
            
            if(!alreadyUsed.Contains(letter))
            {
                code += letter;
                alreadyUsed.Add(letter);
                i++;
            }
        }
      
        return code;
    }
    
}