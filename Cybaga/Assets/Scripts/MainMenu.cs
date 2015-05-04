using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour 
{

	public void LoadLevel()
	{
		Application.LoadLevel("Level1");
	}

	public void QuitGame()
	{
		Application.Quit();
	}

}
