using UnityEngine;
using System.Collections;

namespace AirStrikeKit
{
	public class Mainmeu : MonoBehaviour
	{

		public GUISkin skin;
		public Texture2D Logo;
		public GameObject musicManager;
		private MusicManager musicScript;

		void Start ()
		{
			musicManager = GameObject.Find ("WwiseGlobal");
			musicScript = musicManager.GetComponent<MusicManager> ();
			musicScript.switchMenu ();
			musicScript.playMusic ();
			//AkSoundEngine.SetState ("PlayerLife", "Menu");
			//AkSoundEngine.SetSwitch ("Music", "Menu", uniListener);
			//AkSoundEngine.PostEvent ("PlayMusic", uniListener);

		}

		public void OnGUI ()
		{
			if (skin)
				GUI.skin = skin;
		
			GUI.DrawTexture (new Rect (Screen.width / 2 - Logo.width / 2, Screen.height / 2 - 150, Logo.width, Logo.height), Logo);
		
			if (GUI.Button (new Rect (Screen.width / 2 - 150, Screen.height / 2 + 50, 300, 40), "Classic")) {
				//print ("chosen classic mode");
				//AkSoundEngine.SetSwitch ("Music", "Classic", uniListener);
				musicScript.switchClassic ();
				musicScript.currentMode = 1;
				Application.LoadLevel ("Classic");
			}
			if (GUI.Button (new Rect (Screen.width / 2 - 150, Screen.height / 2 + 100, 300, 40), "Modern")) {
				//AkSoundEngine.SetSwitch ("Music", "Modern", uniListener);
				musicScript.switchModern ();
				musicScript.currentMode = 2;
				Application.LoadLevel ("Modern");
			}
			if (GUI.Button (new Rect (Screen.width / 2 - 150, Screen.height / 2 + 150, 300, 40), "StarFighter")) {
				//AkSoundEngine.SetSwitch ("Music", "Starfighter", uniListener);
				musicScript.switchstarFighter ();
				musicScript.currentMode = 3;
				Application.LoadLevel ("StarFighter");
			}
			/*if (GUI.Button (new Rect (Screen.width / 2 - 150, Screen.height / 2 + 150, 300, 40), "Invasion")) {
				Application.LoadLevel ("Invasion");
			}*/
			/*if (GUI.Button (new Rect (Screen.width / 2 - 150, Screen.height / 2 + 200, 300, 40), "Star Fighter")) {
				Application.LoadLevel ("StarFighter");
			} */
		
			GUI.skin.label.alignment = TextAnchor.MiddleCenter;
			GUI.Label (new Rect (0, Screen.height - 90, Screen.width, 50), "Air strike starter kit. Visual - Rachan Neamprasert - Audio - Richard PT Lai");
			//GUI.Label (new Rect (0, Screen.height - 90, Screen.width, 50), "Air strike starter kit. by Rachan Neamprasert\n www.hardworkerstudio.com");
		}
	}
}