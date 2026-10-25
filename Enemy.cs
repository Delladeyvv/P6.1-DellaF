public abstract class Enemy
{
    public string Name;
    public abstract void Attack();
    public void Patrol()
    {
    Console.WriteLine($"{Name} berpatroli di area.");
    }
}