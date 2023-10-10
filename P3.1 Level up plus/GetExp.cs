public class GetExp
{
    public int Level;
    public float Experience;
    public float ExpNeeded = 100;

    public void GrantExperience()
    {

        Console.WriteLine("How many experience do you grant?");
        int input = int.Parse(Console.ReadLine());
        this.Experience = input;

        // Level Up

        while (this.Experience > this.ExpNeeded)
        {
            this.Level++;
            this.Experience -= this.ExpNeeded;
            this.Experience = (int)this.Experience;
            this.ExpNeeded *= 1.25f;
            
            Console.WriteLine(@$"You level up!
Lvl: {this.Level}, Exp: {this.Experience}");
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