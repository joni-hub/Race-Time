using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject car;
    public float maxPos = 1.8f;
    public float delayTimer = 1.2f;
    float timer;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // limit the updating to every few seconds so that there are less cars randomly generated per frame
        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            // limiting the enemy cars as the same as the player car 
            // so that they don't run out of the screen.
            Vector3 carPosition = new Vector3(Random.Range(-1.74f, 1.8f), transform.position.y, transform.position.z);

            // insitaite the car GameObject
            Instantiate(car, carPosition, transform.rotation);
            timer = delayTimer;
        }

    }
}
