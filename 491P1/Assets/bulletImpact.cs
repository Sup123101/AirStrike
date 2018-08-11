using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletImpact : MonoBehaviour {
    private bool hitsand = false;
    private int hitType = 0;
	//plays bullet sound if it hits terrain
    private void OnEnable()
    {
        if (hitType == 1)
        {
            AkSoundEngine.PostEvent("sandBullet", gameObject);
        }
       

	}
	
    //If it hits scene
    private void OnCollisionEnter(Collision collision)
	{
       
			if (collision.gameObject.tag == "Scene") {
              hitType = 1; 
			}
       

	}
}
