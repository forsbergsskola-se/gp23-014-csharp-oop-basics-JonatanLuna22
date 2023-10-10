public class GetExp
{
    public int Level;
    public float Experience;
    public float ExpNeeded = 100;

    public void GrantExperience()
    {

        Console.WriteLine("How many experience do you grant?");
        int input = int.Parse(Console.ReadLine());
        Experience = input;

        // Level Up

        while (Experience > ExpNeeded)
        {
            Level++;
            Experience -= ExpNeeded;
            Experience = (int)Experience;
            ExpNeeded *= 1.5f;
            
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