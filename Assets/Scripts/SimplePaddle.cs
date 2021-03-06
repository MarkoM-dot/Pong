using UnityEngine;

public class SimplePaddle : Paddle
{
    private float speedModifier = 0.01f;
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + touch.deltaPosition.y * speedModifier);
            }
        }

        CheckForbiddenZone();
    }
}
