using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScaler : MonoBehaviour
{
    public float speed;
    public float bigSize;
    public float smallSize;

    void Update()
    {
        transform.localScale = new Vector4(Mathf.PingPong(Time.time * speed, bigSize) + smallSize, transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }
}
