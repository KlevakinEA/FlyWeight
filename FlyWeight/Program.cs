Character[] characters = new Character[3];
Character_factory factory = new Character_factory();
characters[0] = factory.GetCharacter("Во", "Воин");
characters[1] = factory.GetCharacter("Во", "Волшебник");
characters[2] = factory.GetCharacter("Во", "Воин");
characters[0].Print(10, 1000);
characters[1].Print(3, 100);
characters[2].Print(5, 250);


class Character
{
    public string Name, Class, Image;
    public void Print(int level, int exp)
    {
        Console.WriteLine(Class + " " + level + " уровня " + Name + " с " + exp + " опыта.");
    }
    public Character(string Name, string Class, string Image)
    {
        this.Name = Name;
        this.Class = Class;
        this.Image = Image;
    }
}


class Character_factory
{
    private protected List<Character> characters = new List<Character>();
    public Character GetCharacter(string Name, string Class)
    {
        for (int i = 0; i < characters.Count; i++) if (characters[i].Name == Name & characters[i].Class == Class) return characters[i];
        characters.Add(new Character(Name, Class, ""));
        return characters.Last();
    }
}