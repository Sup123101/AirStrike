using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

	public bool musicPlaying = false;
	// Use this for initialization
	void Start () {
		
	}
	



	public void playMusic()
	{
		if (musicPlaying == false) {
			AkSoundEngine.PostEvent ("PlayMusic", this.gameObject);
			musicPlaying = true;
		}
	}
	public void switchMenu()
	{
		AkSoundEngine.SetSwitch ("Music", "Menu", this.gameObject);
	}
	public void switchClassic()
	{
		AkSoundEngine.SetSwitch ("Music", "Classic", this.gameObject);
	}
	public void switchModern()
	{
		AkSoundEngine.SetSwitch ("Music", "Modern", this.gameObject);
	}
	public void switchstarFighter()
	{
		AkSoundEngine.SetSwitch ("Music", "Starfighter", this.gameObject);
	}


}
