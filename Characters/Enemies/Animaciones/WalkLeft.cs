﻿using UnityEngine;
using System.Collections;

public class WalkLeft : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
				if (Input.GetKey (KeyCode.A)) {
						Vector3 PosActual = transform.position;
						PosActual = PosActual + new Vector3 (-1, 0, 0) * Time.deltaTime;
						transform.position = PosActual;
				}
		}
}
