using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwinStickAIController : MonoBehaviour
{
    public TwinStickMonster controlledMonster;
    StateMachine stateMachine = new StateMachine();
    IdleState idleState;

    void Awake()
    {
        if(controlledMonster == null)
        {
            Debug.LogError("No controllered monster assigned");
            return;
        }
        idleState = new IdleState(controlledMonster);
    }

    void Start()
    {
        stateMachine.ChangeState(idleState);
    }

    void Update()
    {
        stateMachine.Update();
        if (Input.GetKeyDown(KeyCode.F))
        {
            stateMachine.ChangeState(idleState);
        }
    }
}
