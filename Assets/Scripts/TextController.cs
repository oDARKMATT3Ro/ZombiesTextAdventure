using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;

	// Use this for initialization
	void Start () {
		text.text = "Press SPACE to Start Game";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			text.text = "Lorem ipsum dolor sit amet, consectetur " +
						"adipiscing elit. Fusce cursus tristique magna. " +
						"Nullam aliquet tellus a commodo sagittis. Donec " +
						"mattis condimentum purus, vel elementum lacus " +
						"pretium id. Nam nec dolor risus. Suspendisse potenti. " +
						"Vestibulum nec aliquam ante. Sed magna turpis, varius " +
						"et pellentesque pretium, fringilla id orci.";
		}
	}
}
