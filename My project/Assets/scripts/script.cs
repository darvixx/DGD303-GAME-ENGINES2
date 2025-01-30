using UnityEngine;

public class script : MonoBehaviour
{

    gun[] guns;
    float moveSpeed = 5;

    bool moveUp;
    bool moveDown;
    bool moveLeft;
    bool moveRight;
    bool speedUp;
    bool shoot;

    
    void Start()
    {
        guns = transform.GetComponentsInChildren<gun>();

    }

    
    void Update()
    {
        moveUp = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W);
        moveDown = Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S);  
        moveLeft = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A);
        moveRight = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);
        speedUp = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);

        shoot = Input.GetKeyDown(KeyCode.Space);
        if (shoot)
        {
            shoot = false;
            foreach (gun gun in guns)
            {
                gun.Shoot();
            }
        }

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

        if (pos.x <= -1)
        {
            pos.x = -1;
        }

        if (pos.x >= 18)
        {
            pos.x = 18;
        }

        if (pos.y <= 1)
        {
            pos.y = 1;
                }

        if (pos.y >= 10.98f)
        {
            pos.y = 10.98f;
                }

        


        transform.position = pos;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bullet1 bullet1 = collision.GetComponent<bullet1>();
        if (bullet1 != null)
        {
            if (bullet1.isEnemy)
            {
                Destroy(gameObject);
                Destroy(bullet1.gameObject);

            }
        }

        destructable destructable = collision.GetComponent<destructable>();
        if (destructable != null)
        {
            Destroy(gameObject);
            Destroy(destructable.gameObject);

        }
    }
}
