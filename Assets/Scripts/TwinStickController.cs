using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwinStickController : MonoBehaviour
{
    public void LookAtMouse(float Speed)
    {
        Vector3 Target = MouseHelper.Instance.GetMousePosition();
        Quaternion RotateTo = Quaternion.LookRotation(Target - transform.position);
        RotateTo.x = 0;
        RotateTo.z = 0;

        transform.rotation = Quaternion.Lerp(transform.rotation, RotateTo, Speed * Time.fixedDeltaTime);
        //Debug.Log(MouseHelper.GetMousePosition());
    }

    public void Move(CharacterController charController, float Speed)
    {
        float AxisValueH = Input.GetAxis("Horizontal");
        float AxisValueV = Input.GetAxis("Vertical");
        
        Vector3 desiredPosition = new Vector3(AxisValueH, 0, AxisValueV);
        desiredPosition = desiredPosition.normalized * Speed * Time.fixedDeltaTime;
        
        charController.SimpleMove(desiredPosition);
    }
}
