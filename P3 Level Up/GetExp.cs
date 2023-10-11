
public class Player 
{
    public int Level;
    public int Experience;
    
    public void GrantExperience(int input) 
    {
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