public class GetExp 
{
    public int Level;
    public float Experience;
    public float ExpNeeded = 100;
    
    public void GrantExperience() {
        
        Console.WriteLine("How many experience do you grant?");
        int input = int.Parse(Console.ReadLine());
        Experience = input;
        
        // Level Up
        
        while(Experience > ExpNeeded) 
        {
            Level++;
            
            ExpNeeded *= 1.5f;
            Experience -= ExpNeeded;
           
            if (Experience%2 != 0)
            {
                Experience += 0.5f;
            }
        }
        
        Console.WriteLine($"Lvl: {Level}, Exp: {Experience}");
    }
}