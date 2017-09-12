using UnityEngine;

public class MovingToObjectiveState : IState
{
    private TwinStickMonster Owner;

    public MovingToObjectiveState(TwinStickMonster owner)
    {
        Owner = owner;
    }

    public void Enter()
    {

    }

    public void Excute()
    {
        Owner.MoveToTarget();
    }

    public void Exit()
    {

    }
}
