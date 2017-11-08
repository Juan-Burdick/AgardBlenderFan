using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedFanController : MonoBehaviour {
	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}

	public void BladeRotation() {
		anim.CrossFade ("BladeRotation", 1);
	}

	public void BladeHide() {
		anim.CrossFade ("BladeHide", 1);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
