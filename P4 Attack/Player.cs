public class Player
{
    public int Damage;
    
    public void Attack(Player target)
    {
        target.Damage++;
    }
}