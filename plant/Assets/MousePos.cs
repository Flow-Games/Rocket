using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePos : MonoBehaviour
{
    public float inputx;
    public float inputy;
    public float inputz;
    public Transform target;
    public float smoothTime = 0.01f;
    private Vector3 velocity = Vector3.zero;
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        inputx = Input.mousePosition.x;
        inputy = Input.mousePosition.y;
        inputz = Input.mousePosition.z;
        Vector3 targetpos = new Vector3(inputx/100, inputy / 100, 0);
        transform.position = Vector3.MoveTowards(transform.position, targetpos, Time.deltaTime * 7);

        
    }
}
