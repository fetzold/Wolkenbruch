﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlphaButton : MonoBehaviour {

	public float alphaTreshold = 0.1f;

	// Use this for initialization
	void Start () {
		this.GetComponent<Image> ().alphaHitTestMinimumThreshold = alphaTreshold;
	}
}
