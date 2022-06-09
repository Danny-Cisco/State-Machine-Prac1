using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostGame : MonoBehaviour
{
    [SerializeField] TimerSeconds timerSeconds;
    // Start is called before the first frame update
    

    public void PostGameEnter()
    {
        timerSeconds.StartTimerSeconds(2); // how long the Post Game pause will last
    }
}
