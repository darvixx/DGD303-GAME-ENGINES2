using UnityEngine;

public class bullet : MonoBehaviour
{
    public Vector2 direction = new Vector2(0,1);    
    public float speed = 15;

    public Vector2 velocity;

    public bool isEnemy = false;    

    void Start()
    {
        Destroy(gameObject, 5);
    }

    
    void Update()
    {
        velocity = direction * speed;
    }

    private void FixedUpdate()
    {

        Vector2 pos = transform.position;

        pos += velocity * Time.fixedDeltaTime;

        transform.position = pos;
        
    }
}
