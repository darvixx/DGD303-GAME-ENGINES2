using UnityEngine;

public class destructable : MonoBehaviour
{
   
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bullet bullet = collision.GetComponent<bullet>();
        if (bullet != null )
        {
            Destroy(gameObject);
            Destroy(bullet.gameObject);
        }
    }
}
