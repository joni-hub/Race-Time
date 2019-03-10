using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float carSpeed;

    // right limit for the car in x axis from transform.
    public float maxPos = 1.79f;

    Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        // current position gets copied to hte Vector3 position.
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;

        // limits for right and left side of the car.
        position.x = Mathf.Clamp(position.x, -1.72f, 1.79f);

        transform.position = position;
    }

    // when the rigid body car collides with any other/ another rigidbody car (enemy car)
    // the car will get destroyed.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "EnemyCar")
        {
            Destroy(gameObject);
        }
    }
}
