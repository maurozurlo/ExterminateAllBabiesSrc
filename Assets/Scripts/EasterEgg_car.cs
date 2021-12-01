﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasterEgg_car : MonoBehaviour
{
    public Vector3 speed = new Vector3(0,60,0);
    public float maxDistance = 300;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Vector3.Magnitude(Camera.main.transform.position - transform.position));
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * Time.deltaTime;
        if(Vector3.Magnitude(Camera.main.transform.position - transform.position) > maxDistance) {
            Destroy(gameObject);
        }
    }
}
