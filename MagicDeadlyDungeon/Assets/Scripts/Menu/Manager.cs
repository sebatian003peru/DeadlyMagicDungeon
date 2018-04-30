using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Manager : MonoBehaviour {

	public string sceneName;

	public void Load()
	{
		SceneManager.LoadScene (sceneName);
	}

}
