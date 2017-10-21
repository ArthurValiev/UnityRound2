using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTeleport : MonoBehaviour {

    GameObject controller;

	// Use this for initialization
	void Start () {
        controller = GameObject.Find("Controller");
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if(controller.GetComponent<Pointer>().target)
        {
            if(GvrControllerInput.ClickButtonDown)
            {
                var shiftedPos = controller.GetComponent<Pointer>().hitPoint;
                shiftedPos.y += 4;
                transform.position = shiftedPos;
            }
        }

	}
}
