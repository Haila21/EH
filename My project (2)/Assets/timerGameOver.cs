using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class timerGameOver : MonoBehaviour
{
    int countDownStartValue = 60;
    public Text timerUI;
    // Start is called before the first frame update
    void Start()
    {
        countDownTimer();
    }
    void countDownTimer()
    {
        if (countDownStartValue > 0)
        {
            timerUI.text = "The boat will leave after:" + countDownStartValue;
            countDownStartValue--;
            Invoke("countDownTimer", 1.0f);
        }
else{
            timerUI.text = "GameOver";

}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}