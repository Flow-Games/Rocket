using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plant : MonoBehaviour
{
    public GameObject planty;
    public float counter;
    public float velocity = 0;
    void Start()
    {
        
    }

    void Update()
    {
        if (velocity < 5)
        {
            velocity += 0.1f;
            transform.position += new Vector3(0, 1, 0);
        }
    }
}
