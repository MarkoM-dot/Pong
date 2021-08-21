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
            ball.AddForce(-normal * bounceStrength);

        }

        if (collision.otherCollider.CompareTag("Player"))
        {
            float y = CalculatePosition(ball.transform.position, collision.otherCollider.transform.position, collision.otherCollider.bounds.size.y);
            
            Vector2 direction = new Vector2(1, y).normalized;

            collision.rigidbody.velocity = direction * bounceStrength;
        }
        if (collision.otherCollider.CompareTag("Computer"))
        {
            float y = CalculatePosition(ball.transform.position, collision.otherCollider.transform.position, collision.otherCollider.bounds.size.y);
            Vector2 direction = new Vector2(-1, y).normalized;

            collision.rigidbody.velocity = direction * bounceStrength;
        }
      

    }

    float CalculatePosition(Vector2 ballPosition, Vector2 paddlePosition, float paddleHeight)
    {
        float value = (ballPosition.y - paddlePosition.y) / paddleHeight;
        return value;
    }
}
