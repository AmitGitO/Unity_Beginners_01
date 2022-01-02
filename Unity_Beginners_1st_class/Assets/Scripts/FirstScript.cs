using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    public float speedZ = 5;
    public float speedX = 1;
    public Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + direction;
    }

    private void OnEnable()
    {
        transform.position = Vector3.zero;
    }

}
