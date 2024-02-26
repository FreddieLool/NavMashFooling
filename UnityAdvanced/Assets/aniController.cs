using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class aniController : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEvent<float> speedChange;
    [SerializeField]Animator animator;
    [SerializeField] NavigationScript script;
    void Start()
    {
        script.speedChange.AddListener(ChangeSpeed);
    }
    public void ChangeSpeed(float value)
    {
        animator.SetFloat("Speed",value);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
