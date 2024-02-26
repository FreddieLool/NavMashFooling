using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Collect : MonoBehaviour
{
    int balls = 0;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private AudioSource collectSfx;
    public UnityEvent collect;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ball"))
        {
            SFX();
            AddToScore();
            Destroy(collision.gameObject);
        }
    }

    public void SFX()
    {
        collectSfx.Play();
    }

    public void AddToScore()
    {
        balls++;
        scoreText.text = ("Balls: " + balls);
    }
}

