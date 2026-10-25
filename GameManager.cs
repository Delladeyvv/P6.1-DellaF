public class GameManager
{
    private List<GameCharacter> _characters =new();
    public void Spawn(GameCharacter character)
    {
        _characters.Add(character);
    }
    public void UpdateFrame()
    {
        foreach (GameCharacter c in _characters)
            c.Attack();
    }
}