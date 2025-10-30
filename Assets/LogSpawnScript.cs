using UnityEngine;

public class LogSpawnScript : MonoBehaviour
{
    public GameObject log;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnLog();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnLog();
            timer = 0;
        }
    }

    void spawnLog()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(log, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
