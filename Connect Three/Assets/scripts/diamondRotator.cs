﻿using UnityEngine;
using System.Collections;

public class diamondRotator : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.right, Time.deltaTime);
	}
}
