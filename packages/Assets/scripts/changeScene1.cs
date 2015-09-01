using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Timers;

public class changeScene1 : MonoBehaviour {


	public float timer = 54;

	// Use this for initialization
	void Start () {
	 
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Application.isEditor) {
		
			Application.LoadLevel ("menu");
		} else {
			if (timer > 0) {
				timer -= Time.deltaTime;
			}

			if (timer <= 0) {
				Application.LoadLevel ("menu");
			}
		}
	}
}
