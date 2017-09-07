using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwinStickMonster : MonoBehaviour
{
    [SerializeField]
    private float Health;

    public void TakeDamage(float damage)
    {
        Health -= damage;
        if(Health <= 0)
        {
            Debug.Log(gameObject.name + " is dead");
        }
    }

    public float GetHealth()
    {
        return Health;
    }
}
