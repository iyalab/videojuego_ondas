using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	int puntaje = 0;

	void Start () {
		puntaje = PlayerPrefs.GetInt ("Puntaje");
	
	}

	void OnGUI()
	{
		GUI.Label (new Rect (Screen.width / 2 - 40, 50, 200, 100), "FIN DEL JUEGO");

		GUI.Label (new Rect (Screen.width / 2 - 40, 300, 200, 100), "Puntaje: " + puntaje);

		if (GUI.Button (new Rect (Screen.width / 2 - 100, 350, 200, 50), "Otra Vez?")) 
		{
			Application.LoadLevel(1);
		}
		if (GUI.Button (new Rect (Screen.width / 2 - 100, 450, 200, 50), "Ir al inicio")) 
		{
			Application.LoadLevel(0);
		}
	}
}
