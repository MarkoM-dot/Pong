using UnityEngine;

public class PlayerPaddle : Paddle
{
    // This script will contain features specific to the Player
    // Make the Kinematic object move in the fixed update
    private void FixedUpdate()
    {
        float y = Input.GetAxisRaw("Vertical");

        transform.Translate(0, y * Time.deltaTime * speed, 0);
    }
}
