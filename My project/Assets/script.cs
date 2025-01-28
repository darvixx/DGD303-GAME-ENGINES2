using UnityEngine;

public class script : MonoBehaviour
{

    float moveSpeed = 5;

    bool moveUp;
    bool moveDown;
    bool moveLeft;
    bool moveRight;
    bool speedUp;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        moveUp = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W);
        moveDown = Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S);  
        moveLeft = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A);
        moveRight = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);
        speedUp = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);



    }
    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        float moveAmount = moveSpeed * Time.deltaTime;

        if (speedUp)
        {
            moveAmount *= 3;
        }
        Vector2 move = Vector2.zero;


        if (moveUp)
        {
            move.y += moveAmount;

        }

        if (moveDown)
        {
            move.y -= moveAmount;

        }

        if (moveLeft)
        {
            move.x -= moveAmount;
        }
        if (moveRight)
        {
            move.x += moveAmount;
        }

        pos += move;

        if (pos.x <= -16)
        {
            pos.x = -16;
        }

        if (pos.x >= 17.24f)
        {
            pos.x = 17.24f;
        }

        if (pos.y <= -4.21f)
        {
            pos.y = -4.21f;
                }

        if (pos.y >= 16)
        {
            pos.y = 16;
                }

        


        transform.position = pos;

    }
}
