using UnityEngine;
using System.Collections;

public class ControlUI : MonoBehaviour {

	public int escena;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void cargarEscena(){
		Application.LoadLevel(escena);
	}
}
