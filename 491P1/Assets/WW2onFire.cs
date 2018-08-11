using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WW2onFire : MonoBehaviour {

	//When any WW2 plane is on fire, engine sputters and flames audio will start
    private void OnDisable()
    {
        AkSoundEngine.PostEvent("stopEngineSputter", gameObject);
        AkSoundEngine.PostEvent("stopFlames", gameObject);
    }
    private void OnDestroy()
    {
        AkSoundEngine.PostEvent("stopEngineSputter", gameObject);
        AkSoundEngine.PostEvent("stopFlames", gameObject);
    }
    void OnEnable()
    {
        AkSoundEngine.PostEvent("startEngineSputter", gameObject);
        AkSoundEngine.PostEvent("startFlames", gameObject);
    }


	
}
