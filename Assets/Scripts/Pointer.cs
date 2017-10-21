using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour {

    public GameObject target;
    public GameObject pointerDot;
    public Vector3 hitPoint;
    LineRenderer lineRenderer;

	// Use this for initialization
	void Start () {

        pointerDot = GameObject.Find("PointerDot");
        lineRenderer = GetComponent<LineRenderer>();
	}

	// Update is called once per frame
	void FixedUpdate () {
        transform.localRotation = GvrControllerInput.Orientation;
        RaycastHit objectHit;
        Vector3 fwd = transform.forward;

        if (Physics.Raycast(transform.position, fwd, out objectHit, 50))
        {
            target = objectHit.transform.gameObject;
            hitPoint = objectHit.point;
            pointerDot.gameObject.SetActive(true);
            pointerDot.transform.position = hitPoint;

            lineRenderer.enabled = true;
            lineRenderer.SetPosition(0, transform.position);
            lineRenderer.SetPosition(1, objectHit.point);
        }
        else
        {
            target = null;
            pointerDot.gameObject.SetActive(false);
            lineRenderer.SetPosition(0, transform.position);
            lineRenderer.SetPosition(1, transform.position + transform.forward * 50);
        }



	}
}
