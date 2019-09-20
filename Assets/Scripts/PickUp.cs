﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform target;

    private void Update()
    {
        
    }

    private void OnMouseDown()
    {
        this.transform.position = target.position;
        this.transform.parent = GameObject.Find("FPSController").transform;
        this.transform.parent = GameObject.Find("FirstPersonCharacter").transform;
    }

    private void OnMouseUp()
    {
        this.transform.parent = GameObject.Find("FPSController").transform;
        this.transform.parent = null;
    }
}
