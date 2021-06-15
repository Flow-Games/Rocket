using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubemove : MonoBehaviour
{
    public float counter = 4;
    public float speed = move.zorluk;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter -= Time.deltaTime;
        if(counter <= 0)
        {
            if(move.zorluk >= -0.5f)
            {
                move.zorluk *= 1.01f;

            }
            Destroy(gameObject);
            
        }
        transform.position += new Vector3(0, 0, move.zorluk);
        Debug.Log(move.zorluk);
    }
}
