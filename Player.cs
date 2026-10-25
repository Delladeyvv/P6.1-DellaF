public class Player : GameCharacter, IDamageable
{
    public void TakeDamage(int amount)
    {
        Health-=amount;
        Console.WriteLine($"{Name} kehilangan {amount} HP!");
    }
}