using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;


public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI stateIndicator;
    public enum States
    {
        ATTRACT_MODE, PRE_GAME, LEVEL_1, LEVEL_2, LEVEL_3, POST_GAME, JACKPOT, TRY_AGAIN, TEST, SETTINGS
    };
    States state = States.ATTRACT_MODE;

    [SerializeField] TimerSeconds timerSeconds;
    [SerializeField] InputManager inputManager;

    [SerializeField] AttractMode attractMode;
    [SerializeField] PreGame preGame;
    [SerializeField] Level_1 level_1;
    [SerializeField] Level_2 level_2;
    [SerializeField] Level_3 level_3;
    [SerializeField] PostGame postGame;
    [SerializeField] TryAgain tryAgain;
    [SerializeField] Jackpot jackpot;

    public int nextLevel = 1;


    void Update()
    {
        stateIndicator.text = state.ToString(); // Displays the current state of the Game Manager State Machine


        switch (state)
        {
            case States.ATTRACT_MODE: /////////////////////////// ATTRACT MODE //////////////////////////////////////
                {
                    if (inputManager.input_1)
                    {
                        inputManager.input_1 = false;
                        //attractModeExit();
                        state = States.PRE_GAME;
                        preGame.PreGameEnter();
                    }

                    // AttractModeUpdate.AttModeUpdate();
                    break;
                }

            case States.PRE_GAME: /////////////////////////// PRE GAME //////////////////////////////////////
                {
                    if (timerSeconds.timesUp == true)
                    {
                        if (nextLevel == 1)
                        {
                            // PreGameExit();        
                            state = States.LEVEL_1;
                            level_1.Level_1Enter();
                        }
                        else if (nextLevel == 2)
                        {
                            // PreGameExit();        
                            state = States.LEVEL_2;
                            level_2.Level_2Enter();
                        }
                        else if (nextLevel == 3)
                        {
                            // PreGameExit();        
                            state = States.LEVEL_3;
                            level_3.Level_3Enter();
                        }
                    }

                    // PreGameUpdate();
                    break;
                }

            case States.LEVEL_1:  /////////////////////////// LEVEL ONE //////////////////////////////////////
                {
                    if (inputManager.win)
                    {
                        inputManager.win = false;
                        // level_1.Level_1Exit();
                        state = States.PRE_GAME;
                        preGame.PreGameEnter();
                    }
                    else if (inputManager.lose)
                    {
                        inputManager.lose = false;
                        // level_1.Level_1Exit();
                        state = States.POST_GAME;
                        postGame.PostGameEnter();
                    }

                    // level_1.Level_1Update();
                    break;
                }

            case States.LEVEL_2:  /////////////////////////// LEVEL TWO //////////////////////////////////////
                {
                    if (inputManager.win)
                    {
                        inputManager.win = false;
                        // level_2.Level_2Exit();
                        state = States.PRE_GAME;
                        preGame.PreGameEnter();
                    }
                    else if (inputManager.lose)
                    {
                        inputManager.lose = false;
                        // level_2.Level_2Exit();
                        state = States.POST_GAME;
                        postGame.PostGameEnter();
                    }

                    // level_2.Level_2Update();
                    break;
                }

            case States.LEVEL_3:  /////////////////////////// LEVEL THREE //////////////////////////////////////
                {
                    if (inputManager.win)
                    {
                        inputManager.win = false;
                        // level_3.Level_3Exit();
                        state = States.JACKPOT;
                        jackpot.JackpotEnter();
                    }
                    else if (inputManager.lose)
                    {
                        inputManager.lose = false;
                        // level_3.Level_3Exit();
                        state = States.POST_GAME;
                        postGame.PostGameEnter();
                    }

                    // level_3.Level_3Update();
                    break;
                }

            case States.POST_GAME:  /////////////////////////// POST GAME //////////////////////////////////////
                {
                    if (timerSeconds.timesUp)
                    {
                        // PostGameExit();
                        state = States.TRY_AGAIN;
                        // tryAgain.TryAgainEnter();
                    }

                    // PostGameUpdate();
                    break;
                }

            case States.JACKPOT:  /////////////////////////// JACKPOT //////////////////////////////////////
                {
                    if (timerSeconds.timesUp)
                    {
                        timerSeconds.timesUp = false;
                        // jackpot.JackpotExit();
                        state = States.TRY_AGAIN;
                        tryAgain.TryAgainEnter();
                    }

                    // TryAgainUpdate();
                    break;
                }

            case States.TRY_AGAIN:  /////////////////////////// TRY AGAIN //////////////////////////////////////
                {
                    if (inputManager.input_1)
                    {
                        inputManager.input_1 = false;
                        tryAgain.TryAgainExit();
                        state = States.PRE_GAME;
                        preGame.PreGameEnter();
                    }

                    if (timerSeconds.timesUp)
                    {
                        timerSeconds.timesUp = false;
                        tryAgain.TryAgainExit();
                        state = States.ATTRACT_MODE;
                        // attractMode.AttractModeEnter();
                    }

                    // TryAgainUpdate();
                    break;
                }

                case States.TEST:  /////////////////////////// TEST //////////////////////////////////////
                {
                    if(inputManager.back)
                    {
                        inputManager.back = false;
                        state = States.ATTRACT_MODE;
                    }

                    break;
                }

                case States.SETTINGS:  /////////////////////////// SETTINGS //////////////////////////////////////
                {


                    break;
                }

            default:
                return;
        }



        if(inputManager.test)
        {
            inputManager.test = false;
            state = States.TEST;
        }


    }
}