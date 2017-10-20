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

    void Update()
    {
        transform.position = headSet.transform.position + Camera.main.transform.forward * distance;
    }
}
