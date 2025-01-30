using UnityEngine;

public class MoveSine : MonoBehaviour
{
    float sinCenterY;
    public float amplitude = 1;
    public float frequency = 0.5f;




    void Start()
    {
        sinCenterY = transform.position.x;

    }


    void Update()
    {

    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        float sin = Mathf.Sin(pos.y * frequency) * amplitude;
        pos.x = sinCenterY + sin;

        transform.position = pos;
    }
}