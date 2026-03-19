namespace State;

public enum CharacterState
{
    /// <summary>
    /// 角色处于空闲状态，未执行任何动作。
    /// </summary>
    Idle,

    /// <summary>
    /// 角色正在行走。
    /// </summary>
    Walking,

    /// <summary>
    /// 角色正在奔跑。
    /// </summary>
    Running
}