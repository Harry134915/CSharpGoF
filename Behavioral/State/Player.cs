namespace State;

public class Player
{
    public CharacterState State { get; set; }

    public void Update()
    {
        //随着分支越来越多, 逻辑混乱, 难扩展, 难维护
        switch (State)
        {
            case CharacterState.Idle:
                Console.WriteLine("角色待机");
                break;
            case CharacterState.Walking:
                Console.WriteLine("角色行走");
                break;
            case CharacterState.Running:
                Console.WriteLine("角色奔跑");
                break;
        }
    }
}