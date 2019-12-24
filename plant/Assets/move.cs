using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public GameObject cubePrefab;
    Vector3 position;
    public float counter = 0.2f;
    public float konumx;
    public float konumy;
    public float konumz;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter -= Time.deltaTime;
        if (counter <= 0)
        {
            konumx = Random.Range(1, 4);
            konumy = Random.Range(1, 6);
            konumz = Random.Range(1, 6);
            position = new Vector3(konumx, konumy, konumz);
            Instantiate(cubePrefab, position, Quaternion.identity);
            counter = 0.2f;
        }
    }
}
