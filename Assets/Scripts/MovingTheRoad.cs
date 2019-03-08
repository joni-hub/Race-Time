using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTheRoad : MonoBehaviour
{
    public float speed;
    Vector2 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        offset = new Vector2(0, Time.time * speed);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
