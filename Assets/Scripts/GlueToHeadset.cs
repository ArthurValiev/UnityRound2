using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlueToHeadset : MonoBehaviour
{
    GameObject headSet;

    // Use this for initialization
    void Start()
    {
        headSet = GameObject.Find("Headset");
    }

    public float distance;

    void FixedUpdate()
    {
        var yShift = headSet.transform.position;
        yShift.y -= 2;
        var yShift2 = headSet.transform.position;
        yShift.y += 2;
        transform.position = yShift + headSet.transform.forward * distance;
        Camera.main.transform.position = yShift2 + headSet.transform.forward * distance;
        Camera.main.transform.rotation = transform.rotation;
    }
}
