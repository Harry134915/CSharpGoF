namespace State.States;

public class RunState : IState
{
    public void Enter()
    {
        Console.WriteLine("进入奔跑");
    }

    public void Update()
    {
        Console.WriteLine("奔跑中");
    }

    public void Exit()
    {
        Console.WriteLine("离开奔跑");
    }
}