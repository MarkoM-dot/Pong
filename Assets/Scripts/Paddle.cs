using UnityEngine;

public class Paddle : MonoBehaviour
{
    // This script will contain common features both paddles have
    public float speed = 8.0f;
    protected Rigidbody2D _rigidbody;


    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    public void ResetPosition()
    {
        _rigidbody.position = new Vector2(_rigidbody.position.x, 0.0f);
        _rigidbody.velocity = Vector2.zero;
    }    
}
