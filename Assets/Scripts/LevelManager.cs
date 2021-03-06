﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

		public void LoadLevel(string name) {
			Debug.Log("Level load requested for: "+name);
			SceneManager.LoadScene(name);

			}

		public void QuitRequest() {
			Debug.Log("Quit Requested");
			Application.Quit();
		}

		public void LoadNextLevel () {
		Scene sceneLoaded=SceneManager.GetActiveScene();
		SceneManager.LoadScene(sceneLoaded.buildIndex +1);
		}

}
