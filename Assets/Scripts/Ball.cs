using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    private Rigidbody2D _rigidbody;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

        Vector2 direction = new Vector2(x, y);
        _rigidbody.AddForce(direction * this.speed);
    }
    public void AddForce(Vector2 force)
    {
        _rigidbody.AddForce(force);
    }
    public void ResetPosition()
    {
        CenterBall();
        AddStartingForce();
    }
    public void CenterBall()
    {
        _rigidbody.position = Vector3.zero;
        _rigidbody.velocity = Vector3.zero;
    }
}
