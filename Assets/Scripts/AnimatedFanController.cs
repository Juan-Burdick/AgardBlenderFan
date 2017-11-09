using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedFanController : MonoBehaviour {
	private Animator anim;
	private Transform fanTransform = null;

	public float fanHide = 0;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		fanTransform = transform.Find ("AnimatedFan");
	}

	public void BladeRotation() {
		anim.CrossFade ("BladeRotation", 1);
	}

	public void FanHide() {
		fanTransform.Translate (0, fanHide, 0);
		StopCoroutine ("BladeRotation");
	}

	public void FanReappear() {
		fanTransform.Translate (0, -fanHide, 0);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
