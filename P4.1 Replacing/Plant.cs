public class Plant
{
    public bool isGrown;
    
    public void PrintStatus()
    {
        if (isGrown == false)
        {
            Console.WriteLine("Plant is a seed.");
            return;
        } 
        Console.WriteLine("Plant is a tree.");
        return;
    }
    public void Grow()
    {
        Console.WriteLine("Plant is growing.");
        isGrown = true;
    }
}