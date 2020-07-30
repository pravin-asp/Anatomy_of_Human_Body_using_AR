using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGame : MonoBehaviour {

	public void next(string a)
	{
		Application.LoadLevel(a);
	}
	
	public void QuitGame()
	{
		Debug.Log("Quti !");
		Application.Quit();
	}
}
