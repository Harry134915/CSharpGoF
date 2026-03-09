namespace AbstractFactory.Talents;

internal class OrcTalent : ITalent
{
    public void Use()
    {
        Console.WriteLine("兽人使用了天赋，增加了力量和耐力！");
    }
}