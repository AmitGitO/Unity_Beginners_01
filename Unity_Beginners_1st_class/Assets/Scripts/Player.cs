using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Player : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI _score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        _score.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
	
       
        Collectable collectable = other.GetComponent<Collectable>();
        if (collectable)
        {
            score += collectable.value;
            _score.text = "Score: " + score;

            Debug.Log("Score Is " + score);
            other.gameObject.SetActive(false);
        }

    }
}
