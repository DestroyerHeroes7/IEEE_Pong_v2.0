using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public LevelManager levelManager;
    public Rigidbody2D rigidbody;
    public void Start()
    {
        rigidbody.AddForce((Vector2.up + Vector2.right) * 3, ForceMode2D.Impulse);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Player 1 Goal"))
        {
            levelManager.OnPlayer2Score();
            rigidbody.velocity = Vector2.zero;
            levelManager.OnScore("Player 2");
        }
        if (collision.collider.CompareTag("Player 2 Goal"))
        {
            levelManager.OnPlayer1Score();
            rigidbody.velocity = Vector2.zero;
            levelManager.OnScore("Player 1");
        }
    }
}
