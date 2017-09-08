using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwinSticksPlayer : MonoBehaviour
{
    public float MoveSpeed = 10.0f;
    public float RotateSpeed = 10.0f;

    public bool bUsingGamepad = false;

    //public Rigidbody rigidbody;
    public CharacterController characterController;

    [SerializeField]
    protected TwinStickController stickController;
    [SerializeField]
    protected TwinStickWeapon stickWeapon;
	
    void Update()
    {
        if(bUsingGamepad)
        {
            if(Input.GetAxis("Joy Triggers") < 0)
            {
                stickWeapon.Fire();
            }
        }
        else
        {
            if (Input.GetButton("Fire"))
            {
                stickWeapon.Fire();
            }
        }

        if (bUsingGamepad)
        {
            if (Input.GetAxisRaw("Vertical Right") != 0 || Input.GetAxisRaw("Horizontal Right") != 0)
            {
                stickController.ControllerLook(RotateSpeed);
            }

            stickController.MoveController(characterController, MoveSpeed);
        }
        else
        {
            stickController.LookAtMouse(RotateSpeed);
            stickController.MoveKeyboard(characterController, MoveSpeed);
        }

    }
}
