/* Zadání
 * Vytvoř program, který převede zadaný text na morseovku.
 * 
 * Pro zjednodušení vycházej z toho, že bude zadaný text bez háčků a čárek(následně můžeš o tuto možnost vylepšit) a čísel(můžeš taky o toto vylepšit).
 * 
 * Ať nemusíš hledat morseovku, zde je rovnou pole se všemi náhradami za klascké znaky 
 * 
 * string[] morseovyZnaky = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."};
 * 
 * Pokud budeš chtít program vylepšit i o čísla, budeš si muset už patřičné morseovy znaky dohledat a doplnit.
*/


    Console.WriteLine("Zadejte text bez diakritiky, který chcete přeložit do Morseovky: ");
    string zadanyText = Console.ReadLine();

    string[] morseovyZnaky = { ".-/", "-.../", "-.-./", "-../", "./", "..-./", "--./", "..../", "../", ".---/", "-.-/", ".-../", "--/", "-./", "---/", ".--./", "--.-/", ".-./", ".../", "-/", "..-/", "...-/", ".--/", "-..-/", "-.--/", "--../","/",".----/","..---/","...--/","....-/","...../", "-..../", "--.../", "---../", "----./", "-----/" };
    string[] znakyAbecedy = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"," ","1","2","3","4","5","6","7","8","9","0" };
    string[] textKPrevodu = new string[zadanyText.Length];
    string vyslednyText=string.Empty;


   for(int i=0;i<zadanyText.Length;i++)
    {
        textKPrevodu[i] = zadanyText.Substring(i, 1);
    }  
  

   for(int i=0; i< textKPrevodu.Length;i++)
   { 
       for(int j=0; j<znakyAbecedy.Length;j++)
       {
           if (string.Equals(textKPrevodu[i], znakyAbecedy[j], StringComparison.OrdinalIgnoreCase))
           {
            vyslednyText= string.Concat(vyslednyText,morseovyZnaky[j]);
           }
       }
   }

Console.WriteLine(vyslednyText);
Console.ReadLine();