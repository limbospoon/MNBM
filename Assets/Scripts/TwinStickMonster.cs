using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class TwinStickMonster : MonoBehaviour
{
    public float Health;
    public float Speed;

    public NavMeshAgent navMeshAgent;

    public GameObject playerReference;

    void Awake()
    {
        if(navMeshAgent == null)
        {
            Debug.LogError("No NavMeshAgent found!!!");
        }
    }

    void Update()
    {
        MoveToPlayer();
    }

    public void MoveToPlayer()
    {
        Vector3 target = playerReference.transform.position;
        
        navMeshAgent.destination = target;
        //navMeshAgent.isStopped = true;
    }

    public void TakeDamage(float damage)
    {
        Health -= damage;
        if(Health <= 0)
        {
            Debug.Log(gameObject.name + " is dead");
        }
    }
}
