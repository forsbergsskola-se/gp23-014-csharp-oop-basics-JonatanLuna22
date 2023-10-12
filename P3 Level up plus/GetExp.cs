public class Player
{
    public static int Level;
    public static float Experience;
    public static float ExpNeeded = 100;
    
    public void GrantExperience(int input)
    {
        Experience += input;
        
        // Level Up

        if (Experience < ExpNeeded)
        {
            Console.WriteLine($"Lvl: {Level}, Exp: {Experience}");
        }
        
        while (Experience > ExpNeeded)
        {
            Level++;
            Experience -= ExpNeeded;
            Experience = (int)Experience;
            ExpNeeded *= 1.25f;
            
            Console.WriteLine(@$"You level up!
Lvl: {Level}, Exp: {Experience}");
            Console.WriteLine();
        }
    }
}    


                // Esta parte de aqui es para evitar que el restante de experiencia sea un nº con decimales.
                 // Pero no funciona porque los floats son aproximaciones.
                // Instead I use (Experience = (int)Experience;) para forzarlo a que sea un int.
     
                 /*
                 if (Experience%2 != 0)
                 {
                     Experience += 0.5f;
                 }
                 */