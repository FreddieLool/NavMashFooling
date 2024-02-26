using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Collect : MonoBehaviour
{

    public UnityEvent Collection;


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Collection.Invoke();
            Destroy(collision.gameObject);
        }
    }


}

