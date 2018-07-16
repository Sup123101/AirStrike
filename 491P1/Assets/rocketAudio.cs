using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketAudio : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	void Awake()
	{
		AkSoundEngine.PostEvent ("Rocket", gameObject);

	}
	// Update is called once per frame
	void Update () {
		
	}
	void OnDestroy(){
		AkSoundEngine.PostEvent ("stopRocket", gameObject);
	}
}
