public class Player
{
    public int Health;

    public void Attack(Player target)
    {
        target.Health--;
    }
}