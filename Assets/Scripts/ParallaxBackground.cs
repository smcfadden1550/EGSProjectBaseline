﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour {
    //negative will be used for things in front of the camera
    //positive will be used for things behind the camera
    public float scrollSpeed;
    Camera mainCamera;
    Vector2 parallaxFollowCamera;
    private float offset;
	// Use this for initialization
	void Start () {
        mainCamera = Camera.main;
        parallaxFollowCamera = transform.position;
        offset = transform.position.x;
    }
	// idk if this will make performance easier down the road but whatever 
	void LateUpdate () {
        parallaxFollowCamera.x = mainCamera.transform.position.x * scrollSpeed + offset;
        transform.position = parallaxFollowCamera;
    }
}
