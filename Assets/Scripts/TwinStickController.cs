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
        Vector3 Target = new Vector3(Input.GetAxis("Horizontal Right"), 0, Input.GetAxis("Vertical Right"));
        Quaternion RotateTo = Quaternion.LookRotation(Target - transform.position);
        RotateTo.x = 0;
        RotateTo.z = 0;

        transform.rotation = Quaternion.Lerp(transform.rotation, RotateTo, Speed * Time.fixedDeltaTime);
    }

    public void MoveKeyboard(CharacterController charController, float Speed)
    {
        float AxisValueH = Input.GetAxis("Horizontal");
        float AxisValueV = Input.GetAxis("Vertical");
        
        Vector3 desiredPosition = new Vector3(AxisValueH, 0, AxisValueV);
        desiredPosition = desiredPosition.normalized * Speed * Time.fixedDeltaTime;
        
        charController.SimpleMove(desiredPosition);
    }

    public void MoveController(CharacterController charController, float Speed)
    {
        float AxisValueH = Input.GetAxis("Joy Horizontal");
        float AxisValueV = Input.GetAxis("Joy Vertical");

        Vector3 desiredPosition = new Vector3(AxisValueH, 0, AxisValueV);
        desiredPosition = desiredPosition.normalized * Speed * Time.fixedDeltaTime;

        charController.SimpleMove(desiredPosition);
    }
}
