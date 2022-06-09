using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryAgain : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] TimerSeconds timerSeconds;
    
    public void TryAgainEnter()
    {
        timerSeconds.StartTimerSeconds(5); // a delay before returning back to the Attract screen
    }
    
    
    public void TryAgainExit()
    {
        gameManager.nextLevel = 1; // reset the Next Level to 1, ready for the next player
    }
}
