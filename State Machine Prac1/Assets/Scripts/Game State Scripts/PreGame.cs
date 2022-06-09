using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreGame : MonoBehaviour
{
    [SerializeField] TimerSeconds timerSeconds;


    public void PreGameEnter()
    {
        timerSeconds.StartTimerSeconds(2); // how long the pre game pause will last
    }
}
