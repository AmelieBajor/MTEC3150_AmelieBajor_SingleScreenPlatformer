using UnityEngine;

public class BulletScript : MonoBehaviour
{

    public float speed = 10;
    public Vector2 direction;
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.linearVelocity = direction * speed * Time.deltaTime;
    }
}
