using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float carSpeed;
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
        transform.position = position;
    }
}
