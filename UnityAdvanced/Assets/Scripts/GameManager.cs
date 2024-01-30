using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public UnityEvent UnityEvent;
    public ShootBullets shootBullets;
         
    // Start is called before the first frame update
    void Start()
    {
        shootBullets.onBulletHit.AddListener(BulletHitHandler);
    }

    private void BulletHitHandler()
    {
        Debug.Log("bullet hit!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
