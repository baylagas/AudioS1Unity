using UnityEngine;
using System.Collections;
using System;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    Vector3 move;
    SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;
    public int direction;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        //float verticalMove = Input.GetAxis("Vertical");
        //CheckSprite(horizontalMove, verticalMove);
        CheckSprite(horizontalMove);
        move = new Vector3(horizontalMove, 0.0f, 0.0f);
    }

    private void CheckSprite(float pXMove)
    {
        if(pXMove>0)
        {
            spriteRenderer.sprite = spriteArray[0];
            direction = 0;
        }
        else if(pXMove<0)
        {
            spriteRenderer.sprite = spriteArray[1];
            direction = 1;
        }
    }

    void FixedUpdate()
    {
        transform.position += move * speed;
    }
}
