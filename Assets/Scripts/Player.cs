using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 300;
    private float squatsSpeed;
    private Rigidbody2D rigibody;
    private PlayerAnim anim;

    void Start()
    {
        squatsSpeed = speed / 2;
        rigibody = GetComponent<Rigidbody2D>();
        anim = GetComponent<PlayerAnim>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        float h = Input.GetAxisRaw("Horizontal");
        if (h != 0)
        {
            if (h > 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            else if (h < 0)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            anim.PlayeWalk();
        }
        else
        {
            anim.PlayIdle();
        }

        rigibody.velocity = new Vector2(h * speed * Time.deltaTime, rigibody.velocity.y);
    }
}
