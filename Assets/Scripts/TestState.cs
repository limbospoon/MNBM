using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestState : IState
{
    public void Enter()
    {
        Debug.Log("Enter");
    }

    public void Excute()
    {
        Debug.Log("Excute");
    }

    public void Exit()
    {
        Debug.Log("Exit");
    }
}
