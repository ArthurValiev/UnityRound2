using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackpadMovement : MonoBehaviour {

	Vector2 touchVector;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		/*if (GvrControllerInput.IsTouching) { //второй if - проверка на dead zone
			Debug.Log("touch");
			touchVector = GvrControllerInput.TouchPosCentered;
			if ((touchVector.x < 0.3f && touchVector.x > -0.3f) && (touchVector.y < 0.3f && touchVector.y > -0.3f)) {
				Debug.Log("dead");
				return;
			}
			else {
				Debug.Log(touchVector);
			}
		}*/
		touchVector.x = 3f;
		touchVector.y = 7f;
		Debug.Log(touchVector);
	}
}
