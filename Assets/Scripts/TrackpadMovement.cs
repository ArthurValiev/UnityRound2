using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackpadMovement : MonoBehaviour
{

    Vector2 touchVector;

    Vector3 dirVector;

    public float speed;
    private Vector3 velocity = Vector3.zero;

    void Start()
    {

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

            if ((Mathf.Abs(touchVector.x) < 0.3f) && (Mathf.Abs(touchVector.y) < 0.3f))
            { //проверка на dead zone
                //Debug.Log("dead");
                return;
            }
            else
            {
                {
                    transform.Translate(dirVector * Time.fixedDeltaTime * speed);
                }
            }
        }
    }
}