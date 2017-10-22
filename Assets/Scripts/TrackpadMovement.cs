using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackpadMovement : MonoBehaviour
{

    Vector2 touchVector;
    Vector3 dirVector;
    public float speed;

    void Start()
    {
        Camera.main.stereoTargetEye = StereoTargetEyeMask.Both;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GvrControllerInput.IsTouching)
        {
            touchVector = GvrControllerInput.TouchPosCentered;

            dirVector.x = touchVector.x;
            dirVector.y = 0;
            dirVector.z = touchVector.y;

            Vector3 fixedDir = Camera.main.transform.TransformDirection(dirVector);
            fixedDir.y = 0;

            if (!((Mathf.Abs(touchVector.x) < 0.3f) && (Mathf.Abs(touchVector.y) < 0.3f)))
            {
                transform.Translate( fixedDir * Time.fixedDeltaTime * speed);
            }
        }
    }
}