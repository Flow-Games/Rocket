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
            konumx = Random.Range(6f, 10f);
            konumy = Random.Range(-1f, 6f);
            konumz = Random.Range(10f, 15f);
            position = new Vector3(konumx, konumy, konumz);
            Instantiate(cubePrefab, position, Quaternion.identity);
            counter = 0.2f;
            Debug.Log(konumx);
        }
    }
}
