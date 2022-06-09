using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerSeconds : MonoBehaviour
{

    public int seconds;
    public bool timesUp;



    // Start is called before the first frame update
    public void StartTimerSeconds(int seconds)
    {
        StartCoroutine(Timer(seconds));

    }

    IEnumerator Timer(int t)
    {
        Debug.Log("Timer Began");
        timesUp = false;
        yield return new WaitForSeconds(t);
        timesUp = true;
        Debug.Log("Time's Up");

    }

}
