using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

	public void NewGameBtn(){
		Application.LoadLevel (1);
	}
	public void ExitGameBtn(){
		Application.Quit ();
	}
}
