using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jackpot : MonoBehaviour
{
    public TimerSeconds timerSeconds;
    
    public void JackpotEnter()
    {
        timerSeconds.StartTimerSeconds(5); // a delay before moving on to the Try Again screen
    }
}
