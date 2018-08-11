using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXExplosion : MonoBehaviour {

    // Use this for initialization
    private int hitType = 0;
	void Start () {
		
	}
    private void OnEnable()
    {
        
            if (hitType == 1)
            {
                AkSoundEngine.PostEvent("sandSear", gameObject);
            }
            if (hitType == 2)
            {
                AkSoundEngine.PostEvent("metalSear", gameObject);
            //print("playing metal Sear");
           
            }



       // print("Explosion hit type is : " + hitType);
        AkSoundEngine.PostEvent("FXExplosion", gameObject);

    }

	private void OnCollisionEnter(Collision collision)
	{
        if (collision.gameObject.tag == "Scene")
        {
            hitType = 1;

        }
        if (collision.gameObject.tag == "Player")
        {
            hitType = 2;
        }
        if (collision.gameObject.tag == "Enemy")
        {
            hitType = 2;

        }


	}
}
