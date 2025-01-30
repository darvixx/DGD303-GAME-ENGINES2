using UnityEngine;

public class gun : MonoBehaviour
{
    public bullet bullet;
    


    
    

    public bool autoShoot = false;
    public float shootIntervalSeconds = 0.5f;
    public float shootDelaySeconds = 0.0f;
    float shootTimer = 0f;
    float delayTimer = 0f;   




  

    void Start()
    {
        
    }

    
    void Update()
    {
        if (autoShoot)
        {
            if (delayTimer >= shootDelaySeconds)
            {
                if (shootTimer >= shootIntervalSeconds)
                {
                    Shoot();
                    shootTimer = 0;    
                }
                else
                {
                    shootTimer += Time.deltaTime;

                }
            }
            else
            {
                delayTimer += Time.deltaTime;

            }
                
        }
    }

    public void Shoot()
    {
        GameObject go = Instantiate(bullet.gameObject,transform.position, Quaternion.identity);

    }
}
