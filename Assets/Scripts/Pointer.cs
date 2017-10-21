using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour {

    public GameObject target;
    public GameObject pointerDot;
    public Vector3 hitPoint;
    float distance;
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
        //Debug.DrawRay(transform.position, fwd * 50, Color.green);
        if (Physics.Raycast(transform.position, fwd, out objectHit, 50))
        {
            target = objectHit.transform.gameObject;
            hitPoint = objectHit.point;
            pointerDot.gameObject.SetActive(true);
            pointerDot.transform.position = hitPoint;

            distance = Vector3.Distance(transform.position, hitPoint);
            lineRenderer.enabled = true;
            lineRenderer.SetPosition(0, transform.position);
            lineRenderer.SetPosition(1, objectHit.point);
             
        }
        else
        {
            target = null;
            pointerDot.gameObject.SetActive(false);
            lineRenderer.SetPosition(0, transform.position);
            lineRenderer.SetPosition(1, fwd * 50);
        }

	}
}
