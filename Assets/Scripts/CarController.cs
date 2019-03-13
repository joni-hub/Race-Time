using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float carSpeed;
    // right limit for the car in x axis from transform.
    public float maxPos = 1.79f;
    Vector3 position;
    public UIManager ui;
    bool checkAndroidPlatform = false;
    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

#if UNITY_ANDROID
        checkAndroidPlatform = true;
#else
        checkCurrentPlatform = false;
#endif

    }

    // Start is called before the first frame update
    void Start()
    {
        // current position gets copied to hte Vector3 position.
        position = transform.position;

        if(checkAndroidPlatform == true)
        {
            Debug.Log("Android");
        }
        else
        {
            Debug.Log("Mac");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(checkAndroidPlatform)
        {

        }
        else
        {
            position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;

            // limits for right and left side of the car.
            position.x = Mathf.Clamp(position.x, -1.72f, 1.79f);
            transform.position = position;
        }
        position = transform.position;
        position.x = Mathf.Clamp(position.x, -1.72f, 1.79f);
        transform.position = position;
    }

    // when the rigid body car collides with any other/ another rigidbody car (enemy car)
    // the car will get destroyed.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "EnemyCar")
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
            ui.GameOver();
        }
    }

    // left button
    public void MoveLeft()
    {
        rb.velocity = new Vector2(-carSpeed, 0);
    }

    // right button 
    public void MoveRight()
    {
        rb.velocity = new Vector2(carSpeed, 0);
    }

    // stop the car
    public void SetSpeedZero()
    {
        rb.velocity = Vector2.zero;
    }
}
