using UnityEngine;

public class WallSound : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        AudioSource audioSource = GetComponent<AudioSource>();

        if (ball != null)
        {
            if (collision.relativeVelocity.magnitude > 13)
            {
                audioSource.volume = 1f;
                audioSource.Play();
            }
            else if (collision.relativeVelocity.magnitude > 8 && collision.relativeVelocity.magnitude <= 13)
            {
                audioSource.volume = 0.75f;
                audioSource.Play();
            }
            else
            {
                audioSource.volume = 0.5f;
                audioSource.Play();
            }
        }
    }
}
