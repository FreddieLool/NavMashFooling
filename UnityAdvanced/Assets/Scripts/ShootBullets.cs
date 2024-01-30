using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class ShootBullets : MonoBehaviour
{
    [SerializeField] Bullet Bullet;
    [SerializeField] GameObject Shooter;
    [SerializeField] Collision  Target;
    public UnityEvent onBulletHit;


    // Start is called before the first frame update
    void Start()
    {
        ActivateShooting();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void ActivateShooting()
    {
        StartCoroutine(BulletShooter());
    }

    IEnumerator BulletShooter()
    {
        while (true) { 
        Bullet instadBullet = Instantiate(Bullet, transform.position, Quaternion.identity);
            instadBullet.onBulletCollided.AddListener(BulletCollided);
        yield return new WaitForSeconds(5);
        }
    }

    private void BulletCollided(Bullet bullet)
    {
       onBulletHit.Invoke();
    }
}
