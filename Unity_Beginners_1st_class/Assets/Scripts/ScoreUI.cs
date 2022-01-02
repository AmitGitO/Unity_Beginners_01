using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI _score;
    public int scoreValue;
    

    // Start is called before the first frame update

    // Update is called once per frame
    void Start()
    {
        _score.text = "Score: " + scoreValue; 
    }

    private void OnTriggerEnter(Collider other)
    {
        Collectable collectable = other.GetComponent<Collectable>();
        if(collectable.tag == "MyCoin")
        {
            scoreValue += collectable.value;
            _score.text = "Score: " + scoreValue;
        }
    }
}
