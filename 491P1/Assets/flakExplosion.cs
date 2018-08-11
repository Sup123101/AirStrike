using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flakExplosion : MonoBehaviour {


	
	private void OnEnable()
	{
        AkSoundEngine.PostEvent("flakExplosion", gameObject);

	}

}
