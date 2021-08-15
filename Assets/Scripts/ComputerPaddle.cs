using UnityEngine;

public class ComputerPaddle : Paddle
{
    // This script will contain features specific to the computer

    // The computer will track the movement of the ball and move accordingly
    public Rigidbody2D ball;
    

    void FixedUpdate()
    {
        // When the ball moves toward the computer adjust vertical position
        if (ball.velocity.x > 0.0f)
        {
            if (ball.position.y > transform.position.y + 0.2f)
            {
                GoingUp();
            }
            else if (ball.position.y < transform.position.y - 0.2f)
            {
                GoingDown();
            }
        }
        // When the ball moves away from the computer it centers itself
        else
        {
            if (transform.position.y > 0.25)
            {
                GoingDown();
            }
            else if (transform.position.y < -0.25)
            {
                GoingUp();
            }
        }
    }
}
