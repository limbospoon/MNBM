using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwinStickProjectile : MonoBehaviour
{
    public Rigidbody rigidbody;

    private float speed = 50f;

    public float Speed
    {
        get { return speed; }
        set { Speed = value; }
    }

	// Use this for initialization
	void Start ()
    {
        rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        rigidbody.AddForce(transform.forward * Speed * Time.fixedDeltaTime, ForceMode.Impulse);
        Destroy(this.gameObject, 1.2f);
	}
}
