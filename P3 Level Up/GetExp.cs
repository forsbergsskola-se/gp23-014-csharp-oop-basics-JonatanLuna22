
public class Player 
{
    public int Level;
    public int Experience;
    
    public void GrantExperience() {
        
        Console.WriteLine("How many experience do you grant?");
        int input = int.Parse(Console.ReadLine());
        Experience = input;
        
        // Level Up
        
        while(Experience > 99) 
        {
            Level++;
            Experience -= 100;
            
            Console.WriteLine(@$"You level up!
Lvl: {Level}, Exp: {Experience}");
            Console.WriteLine();
        }
    }
}