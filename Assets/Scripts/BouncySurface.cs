using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    // The ball speed will increase over time and allow someone to make a mistake
    public float bounceStrength;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        

        if (ball != null)
        {
            Vector2 normal = collision.GetContact(0).normal;
            ball.AddForce(-normal * this.bounceStrength);

        }

    }
}
