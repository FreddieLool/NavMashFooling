using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class NavigationScript : MonoBehaviour
{
    [SerializeField] NavMeshAgent navMeshAgent;
    [SerializeField] Transform[] pathWaypoints;
    [SerializeField] Animator animator;
    [SerializeField] Animator classAnimator;
    [SerializeField] aniController aniCo;
    public UnityEvent onFinishedTrack;
    public UnityEvent<float> speedChange;
    const string charSpeed = "Speed";

    int waypointIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent.SetDestination(pathWaypoints[waypointIndex ].position);
       

    }

    
    
    // Update is called once per frame
    void Update()
    {
        speedChange.Invoke(navMeshAgent.velocity.magnitude);
        if (!navMeshAgent.isStopped && navMeshAgent.remainingDistance <= 0.1f)
        {
            waypointIndex++;
            if (waypointIndex >= pathWaypoints.Length)
            {
                onFinishedTrack.Invoke();
                animator.SetBool("IsFinished", true);
                //waypointIndex = 0;
            }

            navMeshAgent.SetDestination(pathWaypoints[waypointIndex].position);
        }       
    }
}
