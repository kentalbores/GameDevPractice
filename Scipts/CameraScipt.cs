using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScipt : MonoBehaviour
{
    public float speed = 10f;
    void Update()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(xAxis,yAxis,0f) * (speed * Time.deltaTime);
        transform.position += movement;

    }
}
