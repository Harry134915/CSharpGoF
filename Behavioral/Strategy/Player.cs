namespace Strategy;

internal class Player
{
    public AttackType AttackType { get; set; }

    public void Attack()
    {
        switch (AttackType)
        {
            case AttackType.Sword:
                Console.WriteLine("玩家挥舞剑!");
                break;
            case AttackType.Bow:
                Console.WriteLine("玩家射箭!");
                break;
            case AttackType.Magic:
                Console.WriteLine("玩家发射火球!");
                break;
            default:
                Console.WriteLine("玩家使用空手攻击!");
                break;
        }
    }
}