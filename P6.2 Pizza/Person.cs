public class Person
{
    public Pizza meal;

    public void Eat()
    {
        if (meal > 0)
        {
            Console.WriteLine($"Name: Eating Pizza (x Slices Left).");
            meal--;
        }
        Console.WriteLine($"Name: Pizza is Empty already :(");
    }
}