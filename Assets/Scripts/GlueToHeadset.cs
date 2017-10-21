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
        transform.position = yShift + Camera.main.transform.forward * distance;
    }
}
