using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody rb;
    public float speed = 5f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }

    public void movement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(moveHorizontal * speed, rb.linearVelocity.y);
        if(Input.GetKeyDown(KeyCode.Space))
            {
            rb.AddForce(Vector2.up * 5f, ForceMode.Impulse);
        }
    }
        
 }

