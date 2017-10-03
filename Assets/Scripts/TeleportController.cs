using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportController : MonoBehaviour {

	public void SetGazedAt(bool gazedAt) {
		// Highlight target when it's looked at
		if (gazedAt == true)
			GetComponent<Renderer> ().material.EnableKeyword ("_EMISSION");
		else
			GetComponent<Renderer> ().material.DisableKeyword ("_EMISSION");
	}

	// Use this for initialization
	void Start () {
		SetGazedAt(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
