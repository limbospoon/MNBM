using UnityEngine;

public class MovingToPlayerState : IState
{
    private TwinStickMonster Owner;

    public MovingToPlayerState(TwinStickMonster owner)
    {
        Owner = owner;
    }

    public void Enter()
    {

    }

    public void Excute()
    {
        Owner.MoveToPlayer();
    }

    public void Exit()
    {

    }
}
