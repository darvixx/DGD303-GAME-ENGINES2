using UnityEngine;

public class gun : MonoBehaviour
{
    public bullet bullet;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void Shoot()
    {
        GameObject go = Instantiate(bullet.gameObject,transform.position, Quaternion.identity); 


    }
}
