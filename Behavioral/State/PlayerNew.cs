using State.States;

namespace State;

public class PlayerNew
{
    private CharacterState _state;

    private StateMachine _stateMachine;

    public PlayerNew()
    {
        _stateMachine = new StateMachine(new IdleState());
    }

    public void Update()
    {
        _stateMachine.Update();
    }

    public void ChangeState(CharacterState newState)
    {
        _state = newState;
        switch (_state)
        {
            case CharacterState.Idle:
                _stateMachine.ChangeState(new IdleState());
                break;
            case CharacterState.Walking:
                _stateMachine.ChangeState(new WalkState());
                break;
            case CharacterState.Running:
                _stateMachine.ChangeState(new RunState());
                break;
        }
    }
}