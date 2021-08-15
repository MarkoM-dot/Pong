using UnityEngine;

public class BounceSound : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        AudioSource audioSource = GetComponent<AudioSource>();
        float impact = collision.relativeVelocity.magnitude;
        
        if (ball != null)
        {
            if (impact > 13)
            {
                audioSource.pitch = Random.Range(0.9f, 1.1f);
                audioSource.volume = 1f;
                audioSource.Play();
            }
            else if (impact > 8 && impact <= 13)
            {
                audioSource.pitch = Random.Range(0.9f, 1.1f);
                audioSource.volume = 0.75f;
                audioSource.Play();
            }
            else
            {
                audioSource.pitch = Random.Range(0.9f, 1.1f);
                audioSource.volume = 0.5f;
                audioSource.Play();
            }
        }
    }
}
