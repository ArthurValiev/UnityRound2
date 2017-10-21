using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlueToHeadset : MonoBehaviour
{
    GameObject headSet;
    Vector3 offset; 
    // Use this for initialization
    void Start()
    {
        headSet = GameObject.Find("Headset");
        offset = Camera.main.transform.position - transform.position;
    }

    public float distance;

    void FixedUpdate()
    {
        var yShift = headSet.transform.position;
        yShift.y -= 2;
        //var yShift2 = headSet.transform.position;
        //yShift.y -= 2;
        transform.position = yShift + headSet.transform.forward * distance;
        Camera.main.transform.position = transform.position + offset;
        Camera.main.transform.rotation = transform.rotation;
    }
}
