using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer_script : MonoBehaviour
{
float timer = 0f ;
Text timerText ;

    // Start is called before the first frame update
    void Start()
    {
        timerText = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
      timer += Time.deltaTime ;
      timerText.text = "Time: " + Mathf.Round(timer);
    }
}
