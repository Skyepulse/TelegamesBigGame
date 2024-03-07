using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private int movingDirection = 0;

    void Start()
    {
        
    }

    void Update()
    {
        movement_inputs();
    }

    private void movement_inputs()
    {
        if (movingDirection != 0)
        {
            switch (movingDirection)
            {
                case 1:
                    if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
                    {
                        transform.Translate(Vector3.up * speed * Time.deltaTime);
                        movingDirection = 1;
                        return;
                    }
                    break;
                case 2:
                    if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
                    {
                        transform.Translate(Vector3.down * speed * Time.deltaTime);
                        movingDirection = 2;
                        return;
                    }
                    break;
                case 3:
                    if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
                    {
                        transform.Translate(Vector3.left * speed * Time.deltaTime);
                        movingDirection = 3;
                        return;
                    }
                    break;
                case 4:
                    if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                    {
                        transform.Translate(Vector3.right * speed * Time.deltaTime);
                        movingDirection = 4;
                        return;
                    }
                    break;
            }
            movingDirection = 0;
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            movingDirection = 1;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
            movingDirection = 2;
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            movingDirection = 3;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            movingDirection = 4;
        }
    }
}

