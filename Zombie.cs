public class Zombie :Enemy
{
    public override void Attack()
    {
        Console.WriteLine($"{Name} mencakar dengan buas!");
    }
}