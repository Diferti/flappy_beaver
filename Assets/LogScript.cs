using UnityEngine;

public class LogScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deleteZone = -20;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < deleteZone)
        {
            Destroy(gameObject);
        }
    }
}
