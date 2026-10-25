using System;

public class DestructibleCrate : IDamageable
{
    public int Durability = 30;
    public void TakeDamage(int amount)
    {
        Durability-=amount;
        if (Durability <=0)
        Console.WriteLine("Crate hancur berkeping-keping!");
    }
}