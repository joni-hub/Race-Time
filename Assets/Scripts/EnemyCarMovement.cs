using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCarMovement : MonoBehaviour
{
    public float speed = 8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // car will move only in Y direction.
        transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime);
    }
}
