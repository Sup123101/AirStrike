using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WW2onFire : MonoBehaviour {

	
    private void OnDisable()
    {
        AkSoundEngine.PostEvent("stopEngineSputter", gameObject);
    }
    private void OnDestroy()
    {
        AkSoundEngine.PostEvent("stopEngineSputter", gameObject);
    }
    void OnEnable()
    {
        AkSoundEngine.PostEvent("startEngineSputter", gameObject);
    }


	
}
