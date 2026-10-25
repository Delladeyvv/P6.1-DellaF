using System;

public class Healer : GameCharacter
{
    public override void Attack()
    {
        Console.WriteLine($"{Name} memukul dengan tongkat suci sambil menyembuhkan sekutu!");
    }
}