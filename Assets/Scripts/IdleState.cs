using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : IState
{
    TwinStickMonster owner;

    public IdleState(TwinStickMonster owner)
    {
        this.owner = owner;
    }

    public void Enter()
    {
        Debug.Log("Idle Enter");
        owner.Idle();
    }

    public void Excute()
    {
        Debug.Log("Idle Excute");
    }

    public void Exit()
    {
        Debug.Log("Idle Exit");
    }
}
