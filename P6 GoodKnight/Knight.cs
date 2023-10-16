public class Knight
{
    public Sword Sword;
    public Shield Shield; // 2 -> 3

                          // 0
    void GetHit(Sword attackersSword)
    {
        if (this.Shield != null)
        {
            if (attackersSword != null)
            {
                this.Shield = null;
                Console.WriteLine("Knights Shield was pierced by the Sword.");
            }
            else
            {
                Console.WriteLine("Knights Shield fends off the strike.");
            }
        }
        else 
            Console.WriteLine("The Knight has no Shield and is wounded.");
    }  
                                 // 2
    public void Attack(Knight knightDefend)
    {      // 1
        if (Sword != null)
        {
            Console.WriteLine("Knights attacks Knight with a Sword.");
        }
        else
        {
            Console.WriteLine("Knight attacks Knight with Bare Hands.");
        }
        // 2                 // 0
        knightDefend.GetHit(Sword);
    }
}

// I coud create a variable bool HasSword instead of Sword != null.

/*
 
 public void GetHit(Sword sword)
 {
     if (sword != null && Shield != null)
     {
         Shield = null;
         Console.WriteLine("Knights Shield was pierced by the Sword.");
     }

     else if (sword != null && Shield == null)
     {
         Console.WriteLine("The Knight has no Shield and is wounded.");
     }

     else if (sword == null && Shield != null)
     {
         Console.WriteLine("Knights Shield fends off the strike.");
     }
 }
 
*/
