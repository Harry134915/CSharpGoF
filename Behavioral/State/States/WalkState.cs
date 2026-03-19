namespace State.States;

public class WalkState : IState
{
    public void Enter()
    {
        Console.WriteLine("进入行走");
    }

    public void Update()
    {
        Console.WriteLine("行走中");
    }

    public void Exit()
    {
        Console.WriteLine("离开行走");
    }
}