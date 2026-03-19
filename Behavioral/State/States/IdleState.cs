namespace State.States;

public class IdleState : IState
{
    public void Enter()
    {
        Console.WriteLine("进入待机");
    }

    public void Update()
    {
        Console.WriteLine("待机中");
    }

    public void Exit()
    {
        Console.WriteLine("离开待机");
    }
}