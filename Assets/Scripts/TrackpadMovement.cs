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
			newPos = Vector3.ProjectOnPlane(Camera.main.transform.up, Vector3.up).normalized;
			//if (touchVector.y > 0) {				
			//	newPos.z += 0.2f;
			//}
			if (touchVector.x > 0) {
				newPos.x += 0.2f;
			}
			else {
				newPos.x -= 0.2f;
			}
			transform.position = transform.TransformPoint(newPos);
		}
	}
}
