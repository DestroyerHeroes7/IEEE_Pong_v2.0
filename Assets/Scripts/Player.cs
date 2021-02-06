using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public KeyCode upKey;
    public KeyCode downKey;
    public float speed;
    public bool canMove = true;
    void Update()
    {
        if(canMove)
        {
            if (Input.GetKey(upKey))
                transform.Translate(Vector2.up * speed * Time.deltaTime);
            if (Input.GetKey(downKey))
                transform.Translate(Vector2.down * speed * Time.deltaTime);
            transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, -4.2f, 4.2f));
        }
    }
    public void ToogleMove(bool enable)
    {
        canMove = enable;
    }
}