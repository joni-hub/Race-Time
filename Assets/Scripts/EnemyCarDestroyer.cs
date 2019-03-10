using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCarDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "EnemyCar")
        {
            Destroy(collision.gameObject);
        }
    }
}
