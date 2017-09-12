using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;
using System.Linq;

public enum MonsterState
{
    MoveToObjective = 0
}

public class TwinStickMonster : MonoBehaviour
{
    public float Health;
    public float Speed;

    public NavMeshAgent navMeshAgent;

    public TwinSticksPlayer playerReference;
    public Transform objective;

    public StateMachine stateMachine = new StateMachine();

    public MonsterState monsterState = MonsterState.MoveToObjective;

    Dictionary<IState, int> monsterStates = new Dictionary<IState, int>();

    void Setup()
    {
        monsterStates.Add(new MovingToObjectiveState(this), 0);
    }

    void Awake()
    {
        /*if(navMeshAgent == null)
        {
            Debug.LogError("No NavMeshAgent found!!!");
            return;
        }*/
        Setup();
        Debug.Log(monsterStates.FirstOrDefault(x => x.Value == (int)MonsterState.MoveToObjective));
    }

    public void MoveToPlayer()
    {
        Vector3 target = playerReference.transform.position;
        Quaternion RotateTo = Quaternion.LookRotation(target - transform.position);
        RotateTo.x = 0;
        RotateTo.z = 0;

        transform.rotation = Quaternion.Lerp(transform.rotation, RotateTo,50 * Time.fixedDeltaTime);
        if(Vector3.Distance(transform.position, target) < 2.5f)
        {
            navMeshAgent.isStopped = true;
        }
        else
        {
            navMeshAgent.destination = target;
            navMeshAgent.isStopped = false;
        }
    }

    public void MoveToTarget()
    {
        Vector3 target = objective.position;
        Quaternion RotateTo = Quaternion.LookRotation(target - transform.position);
        RotateTo.x = 0;
        RotateTo.z = 0;

        transform.rotation = Quaternion.Lerp(transform.rotation, RotateTo, 50 * Time.fixedDeltaTime);
        if (Vector3.Distance(transform.position, target) < 2.5f)
        {
            navMeshAgent.isStopped = true;
            //stateMachine.ChangeState();
        }
        else
        {
            navMeshAgent.destination = target;
            navMeshAgent.isStopped = false;
        }
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
