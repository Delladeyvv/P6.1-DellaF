public class GameCharacter
{
    public string Name;
    public int Health = 100;
    public virtual void Attack()
    {
        Console.WriteLine($"{Name} menyerang dengan caraumum.");
    }
}