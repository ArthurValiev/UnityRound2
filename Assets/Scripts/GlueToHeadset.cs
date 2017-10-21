using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlueToHeadset : MonoBehaviour
{
    GameObject headSet;
    Vector3 localCoor;

    // Use this for initialization
    void Start()
    {
        headSet = GameObject.Find("Headset");

        localCoor = headSet.transform.InverseTransformPoint(Camera.main.transform.position);
        localCoor.y += 0.5f;
        localCoor.x -= 0.5f;
        localCoor.z -= 0.5f;
    }

    public float distance;

    void FixedUpdate()
    {
        var yShift = headSet.transform.position;
        yShift.y -= 2;
        transform.position = yShift + headSet.transform.forward * distance;

        Camera.main.transform.position = transform.TransformPoint(localCoor);
        Camera.main.transform.rotation = transform.rotation;
        Camera.main.transform.forward = transform.forward;

        Debug.Log(transform.forward);
    }
}
