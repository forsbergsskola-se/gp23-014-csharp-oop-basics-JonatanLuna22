public class Knight
{
    public Sword Sword;
    public Shield Shield;

    public void SwordOn()
    {
        Sword = true;
    }

   

    public void GetHit(Sword sword)
    {
        while ()
        {
            Console.WriteLine("Knights Shield was pierced by the Sword.");
        }
        Console.WriteLine("Knights Shield fends off the strike.");
    }
    
    public void Attack(Knight knight)
    {
        while (knight.Sword == Sword)
        {
            Console.WriteLine("Knights attacks Knight with a Sword.");
           
        }
        Console.WriteLine("Knight attacks Knight with Bare Hands.");
    }
}