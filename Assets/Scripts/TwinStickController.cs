using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwinStickController : MonoBehaviour
{
    public void LookAtMouse(float Speed)
    {
        Vector3 Target = MouseHelper.Instance.GetMousePosition();
        Quaternion RotateTo = Quaternion.LookRotation(Target - transform.position);
        
        transform.rotation = Quaternion.Slerp(transform.rotation, RotateTo, Speed * Time.deltaTime);
        //Debug.Log(MouseHelper.GetMousePosition());
    }
}
