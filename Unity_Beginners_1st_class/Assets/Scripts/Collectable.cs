using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//great name!
public class Collectable : MonoBehaviour
{
    public int value = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
		//this will trigger in any situation, because all the logic is on the player I would remove this method.
        Debug.Log("Collected" + gameObject.name);
    }

}
