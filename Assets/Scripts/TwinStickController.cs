using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwinStickController : MonoBehaviour
{
    void LookAtMouse(float Speed)
    {
        Debug.Log(MouseHelper.GetMousePosition());
    }
}
