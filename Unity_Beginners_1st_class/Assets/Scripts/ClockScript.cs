using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClockScript : MonoBehaviour
{
    public float timeStart;
    public TextMeshProUGUI timeNum;

    // Start is called before the first frame update
    void Start()
    {
        timeNum.text = timeStart.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        
        timeStart += Time.deltaTime;
        timeNum.text = timeStart.ToString("F2");

    }
}
