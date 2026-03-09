namespace AbstractFactory.Talents;

public class HumanTalent : ITalent
{
    public void Use()
    {
        Console.WriteLine("使用人族天赋, 增加经验值获取效率!");
    }
}