using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D rb;
    public Spawner spawner;
    public float jumpSpeed = 10;

    private void Update()
    {
        if(Input.anyKey) Jump();
    }

    void Jump()
    {
        rb.velocity = Vector2.up * jumpSpeed;
    }
}
