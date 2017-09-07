using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwinStickProjectile : MonoBehaviour
{
    public Rigidbody rigidbody;

    public float Speed = 1f;
    public float Damage = 1f;
    
	// Use this for initialization
	void Awake ()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.collider.tag == "Enemy")
        {
            other.collider.GetComponent<TwinStickMonster>().TakeDamage(Damage);
        }

        Debug.Log("I hit " + other.collider.name);
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        rigidbody.AddForce(transform.forward * Speed * Time.fixedDeltaTime, ForceMode.Impulse);
        Destroy(this.gameObject, 1.2f);
	}
}
