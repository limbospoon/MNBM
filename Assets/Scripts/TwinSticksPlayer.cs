using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwinSticksPlayer : MonoBehaviour
{
    public float MoveSpeed = 10.0f;
    public float RotateSpeed = 10.0f;

    //public Rigidbody rigidbody;
    public CharacterController characterController;

    [SerializeField]
    protected TwinStickController stickController;
 
    
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        //stickController.LookAtMouse(RotateSpeed);
        //stickController.MoveKeyboard(characterController, MoveSpeed);

        if (Input.GetAxisRaw("Vertical Right") != 0 || Input.GetAxisRaw("Horizontal Right") != 0)
        {
            stickController.ControllerLook(RotateSpeed);
        }
        stickController.MoveController(characterController, MoveSpeed);
    }
}
