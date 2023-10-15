public class Knight
{
    public Sword Sword;
    public Shield Shield;
    
    void GetHit(Sword sword)
    {
        if (sword != null)
        {
            if (Shield != null)
            {
                Shield = null;
                Console.WriteLine("Knights Shield was pierced by the Sword.");
            }
            else 
                Console.WriteLine("The Knight has no Shield and is wounded.");
        }

        else if (Shield != null)
        {
            Console.WriteLine("Knights Shield fends off the strike.");
        }
    }  
    
    public void Attack(Knight knightDefend)
    {
        if (Sword != null)
        {
            Console.WriteLine("Knights attacks Knight with a Sword.");
        }
        else
        {
            Console.WriteLine("Knight attacks Knight with Bare Hands.");
        }
             
        knightDefend.GetHit(Sword);
    }
}

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
