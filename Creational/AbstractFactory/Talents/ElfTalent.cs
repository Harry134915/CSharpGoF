namespace AbstractFactory.Talents;

internal class ElfTalent : ITalent
{
    public void Use()
    {
        Console.WriteLine("精灵使用了天赋，增加了敏捷和魅力！");
    }
}