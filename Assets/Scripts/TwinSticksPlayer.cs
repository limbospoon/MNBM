using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwinSticksPlayer : MonoBehaviour
{
    public float RotateSpeed = 10.0f;

    [SerializeField]
    protected TwinStickController stickController;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        stickController.LookAtMouse(RotateSpeed);
	}
}
