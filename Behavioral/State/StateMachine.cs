namespace State;

public class StateMachine
{
    private IState _currentState;

    public StateMachine(IState defaultState)
    {
        _currentState = defaultState;
        _currentState.Enter();
    }

    public void ChangeState(IState newState)
    {
        _currentState.Exit();

        _currentState = newState;

        _currentState.Enter();
    }

    public void Update()
    {
        _currentState.Update();
    }
}