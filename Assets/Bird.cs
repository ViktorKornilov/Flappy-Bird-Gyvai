using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D rb;


    private void Update()
    {
        if(Input.anyKey) Jump();
    }

    void Jump()
    {
        rb.velocity = new Vector2(0, 5);
    }
}
