using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackpadMovement : MonoBehaviour {

	Vector2 touchVector;
	Vector3 newPos;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (GvrControllerInput.IsTouching) { 
			//Debug.Log("touch");
			touchVector = GvrControllerInput.TouchPosCentered;
			if ((Mathf.Abs(touchVector.x) < 0.3f) && (Mathf.Abs(touchVector.y) < 0.3f)) { //проверка на dead zone
				//Debug.Log("dead");
				return;
			}
			newPos = Vector3.ProjectOnPlane(Camera.main.transform.forward, Vector3.up).normalized;
			if (touchVector.y > 0) {				
				transform.Translate(newPos);

			}
			if (touchVector.x > 0) {				
				transform.Translate(Vector3.right * 0.1f, Camera.main.transform);
			}
			else {
				transform.Translate(Vector3.left * 0.1f, Camera.main.transform);
			}
			
		}
	
		
	}
}
