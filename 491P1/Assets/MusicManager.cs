using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

	public bool musicPlaying = false;
	public int currentMode = 0; // 0 = Menu, 1 = Classic, 2 = Modern, 3 = starFgither
	// Use this for initialization
	void Start () {
		currentMode = 0;
	}
	



	public void playMusic()
	{
		if (musicPlaying == false) {
			AkSoundEngine.PostEvent ("PlayMusic", this.gameObject);
			musicPlaying = true;
		}
	}
	//only used to restart music after player dies
	public void playModeMusic()
	{
		//AkSoundEngine.PostEvent ("StopEverything", this.gameObject);
		AkSoundEngine.PostEvent ("stopMusic", this.gameObject);
		AkSoundEngine.PostEvent ("PlayMusic", this.gameObject);
		if (currentMode == 0) {
			
			AkSoundEngine.SetSwitch ("Music", "Menu", this.gameObject);
            AkSoundEngine.PostEvent("stopVA", this.gameObject);
		}
		if (currentMode == 1) {
			
			AkSoundEngine.SetSwitch ("Music", "Classic", this.gameObject);
            AkSoundEngine.PostEvent("stopVA", this.gameObject);
            AkSoundEngine.PostEvent("stopVA", this.gameObject);
			/*
			print ("this gets called");
			print ("current mode is " + currentMode);
			resumeMusic ();
			AkSoundEngine.PostEvent ("PlayMusic", this.gameObject);
			AkSoundEngine.SetSwitch ("Music", "Classic", this.gameObject);
			*/
		}
		if (currentMode == 2) {
			
			AkSoundEngine.SetSwitch ("Music", "Modern", this.gameObject);
            AkSoundEngine.PostEvent("stopVA", this.gameObject);
            AkSoundEngine.PostEvent("modernVA", this.gameObject);
		}
		if (currentMode == 3) {
			
			AkSoundEngine.SetSwitch ("Music", "Starfighter", this.gameObject);
            AkSoundEngine.PostEvent("stopVA", this.gameObject);
            AkSoundEngine.PostEvent("starVA", this.gameObject);
		}

	}
	public void switchMenu()
	{
		//AkSoundEngine.PostEvent ("StopEverything", this.gameObject);
		AkSoundEngine.SetSwitch ("Music", "Menu", this.gameObject);
        AkSoundEngine.PostEvent("stopVA", this.gameObject);
	}
	public void switchClassic()
	{
		//AkSoundEngine.PostEvent ("StopEverything", this.gameObject);
		AkSoundEngine.SetSwitch ("Music", "Classic", this.gameObject);
        AkSoundEngine.PostEvent("stopVA", this.gameObject);
        AkSoundEngine.PostEvent("classicVA", this.gameObject);

	}
	public void switchModern()
	{
		//AkSoundEngine.PostEvent ("StopEverything", this.gameObject);
		AkSoundEngine.SetSwitch ("Music", "Modern", this.gameObject);
        AkSoundEngine.PostEvent("stopVA", this.gameObject);
        AkSoundEngine.PostEvent("modernVA", this.gameObject);
	}
	public void switchstarFighter()
	{
		//AkSoundEngine.PostEvent ("StopEverything", this.gameObject);
		AkSoundEngine.SetSwitch ("Music", "Starfighter", this.gameObject);
        AkSoundEngine.PostEvent("stopVA", this.gameObject);
        AkSoundEngine.PostEvent("starVA", this.gameObject);
	}
	public void pauseMusic()
	{
		AkSoundEngine.PostEvent ("PauseMusic", this.gameObject);
        AkSoundEngine.PostEvent("pauseVA", this.gameObject);
	}
	public void resumeMusic()
	{
		AkSoundEngine.PostEvent ("ResumeMusic", this.gameObject);
        AkSoundEngine.PostEvent("resumeVA", this.gameObject);
	}

}
