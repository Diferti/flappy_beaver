using UnityEngine;

public class BeaverScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    private LogicScript logic;
    public bool beaverIsAlive = true;
    public float deadZoneUp = 9;
    public float deadZoneBot = -9;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (beaverIsAlive && (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0)))
        {
            myRigidbody.linearVelocity = new Vector2(myRigidbody.linearVelocity.x, flapStrength);
        }

        if (transform.position.y > deadZoneUp || transform.position.y < deadZoneBot)
        {
            logic.gameOverScreen();
            beaverIsAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOverScreen();
        beaverIsAlive = false;
    }
}
