using System;

public class Assassin : GameCharacter
{
    public override void Attack()
    {
        Console.WriteLine($"{Name} menyerang dari bayangan dengan backstab kritikal!");
    }
}