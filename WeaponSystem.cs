public class WeaponSystem
{
    public void Attack()
{
        Console.WriteLine("Menyerang dengan damage default: 10");
}
    
    public void Attack(int damage)
{
        Console.WriteLine($"Menyerang dengan damage: {damage}");
}
    public void Attack(string target, int damage)
{
        Console.WriteLine($"Menyerang {target} sebesar {damage} dmg");
}
    
    public void Attack(float criticalMultiplier)
{
        int dmg =(int)(10 *criticalMultiplier);
        Console.WriteLine($"Critical hit! Damage: {dmg}");
    }
}