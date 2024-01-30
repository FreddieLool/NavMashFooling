using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bullet : MonoBehaviour
{
    public UnityEvent<Bullet> onBulletCollided;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        onBulletCollided.Invoke(this);
    }
}
