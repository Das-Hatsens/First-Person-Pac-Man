﻿using UnityEngine;
using System.Collections;

public class move : MonoBehaviour
{
    float speed = 0.05f;
    Vector3 direction;

    // Use this for initialization
    void Start()
    {
        direction = new Vector3(0, 0, speed);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + direction;
    }
    void OnGUI()
        
        if (e.type == EventType.KeyDown && e.isKey)
        {
            if (e.keyCode == KeyCode.LeftArrow)
            {
                direction =  Quaternion.Euler(0, -90, 0) * direction;
                transform.Rotate(0, -90, 0);
            }
            else if (e.keyCode == KeyCode.RightArrow)
            {
                direction =  Quaternion.Euler(0, 90, 0) * direction;
                transform.Rotate(0, 90, 0);
            }
        }
    }
}