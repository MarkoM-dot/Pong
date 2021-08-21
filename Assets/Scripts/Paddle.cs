using UnityEngine;

public class Paddle : MonoBehaviour
{
    // This script will contain common features both paddles have
    public float topScreenEdge = 4.2f;
    public float bottomScreenEdge = -4.2f;
    protected float speed = 7.0f;
    protected Rigidbody2D _rigidbody;



    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        CheckForbiddenZone();
    }
    public void ResetPosition()
    {
        _rigidbody.position = new Vector2(_rigidbody.position.x, 0.0f);
    }
    protected void GoingDown()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed);
    }
    protected void GoingUp()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }
    protected void CheckForbiddenZone()
    {
        if (_rigidbody.transform.position.y < bottomScreenEdge)
        {
            _rigidbody.transform.position = new Vector2(_rigidbody.transform.position.x, bottomScreenEdge);
        }
        if (_rigidbody.transform.position.y > topScreenEdge)
        {
            _rigidbody.transform.position = new Vector2(_rigidbody.transform.position.x, topScreenEdge);
        }
    }
}
