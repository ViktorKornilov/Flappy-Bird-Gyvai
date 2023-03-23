using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    public TMP_Text scoreText;
    public Rigidbody2D rb;
    public Spawner spawner;
    public float jumpSpeed = 10;

    public int score;

    private void Start()
    {
        Time.timeScale = 0;
    }

    public void BeginGame()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {
        transform.rotation = Quaternion.Euler(0,0,rb.velocity.y * 10);
        if(Input.anyKey) Jump();
    }

    void Jump()
    {
        rb.velocity = Vector2.up * jumpSpeed;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        print(":(");
        SceneManager.LoadScene(0);
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        print(":)");
        score++;
        // TMP
        scoreText.text = score.ToString();

    }
}
