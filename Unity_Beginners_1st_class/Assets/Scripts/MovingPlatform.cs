using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed;
    public Vector3 point1;
    public Vector3 point2;
    public Vector3 direction;
    private bool isGoingToPoint2;
    // Start is called before the first frame update
    void Start()
    {
        direction = (point2 - point1).normalized;
        transform.position = point1;
        isGoingToPoint2 = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + direction * speed;
        if (isGoingToPoint2)
        {
            if (Vector3.Distance(transform.position, point2) < 0.3f)
            {
                direction = direction * -1;
                isGoingToPoint2 = false;
            }
        }
        else
        {
            if (Vector3.Distance(transform.position, point1) < 0.3f)
            {
                direction = direction * -1;
                isGoingToPoint2 = true;

            }
        }
    }

}
