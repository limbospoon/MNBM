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
    }

    public void ControllerLook(float Speed)
    {
        Vector3 StickDirection = new Vector3(Input.GetAxis("Horizontal Right"), 0, Input.GetAxis("Vertical Right"));
        Vector3 Target = transform.position + StickDirection;
        Quaternion RotateTo = Quaternion.LookRotation(Target - transform.position);
        RotateTo.x = 0;
        RotateTo.z = 0;

        transform.rotation = Quaternion.Lerp(transform.rotation, RotateTo, Speed * Time.fixedDeltaTime);
    }

    public void MoveKeyboard(CharacterController charController, float Speed)
    {
        float AxisValueH = Input.GetAxis("Horizontal");
        float AxisValueV = Input.GetAxis("Vertical");
        
        Vector3 desiredDirection = new Vector3(AxisValueH, 0, AxisValueV);
        desiredDirection *= Speed;

        if(AxisValueH != 0 && AxisValueV != 0)
        {
            desiredDirection = desiredDirection * 0.75f;
        }

        charController.Move(desiredDirection * Time.deltaTime);
    }

    public void MoveController(CharacterController charController, float Speed)
    {
        float AxisValueH = Input.GetAxis("Joy Horizontal");
        float AxisValueV = Input.GetAxis("Joy Vertical");

        Vector3 desiredDirection = new Vector3(AxisValueH, 0, AxisValueV);
        desiredDirection *= Speed;

        if (AxisValueH != 0 && AxisValueV != 0)
        {
            desiredDirection = desiredDirection * 0.75f;
        }

        charController.Move(desiredDirection * Time.deltaTime);
    }
}
