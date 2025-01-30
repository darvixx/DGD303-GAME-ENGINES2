using UnityEngine;

public class MoveRightLeft : MonoBehaviour
{
    public float moveSpeed = 4;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;   

        pos.y -= moveSpeed * Time.deltaTime;    

        if (pos.y < -11)
        {
            Destroy(gameObject);
        }

        transform.position = pos;   


    }
}
