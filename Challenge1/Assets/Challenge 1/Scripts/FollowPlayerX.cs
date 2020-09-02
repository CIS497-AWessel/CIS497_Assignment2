﻿/*
 * Anthony Wessel
 * Assignment 1 Challenge
 * Make the camera follow the player
 */
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
