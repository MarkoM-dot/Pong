using UnityEngine;

public class PlayerPaddle : Paddle
{
    // This script will contain features specific to the Player
    // Make the Kinematic object move in the fixed update
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            GoingUp();
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            GoingDown();
        }
        
        CheckForbiddenZone();
    }
}
