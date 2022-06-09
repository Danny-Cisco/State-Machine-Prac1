using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public bool input_1;
    public bool win;
    public bool lose;
    public bool test;
    public bool service;
    public bool back;
    public bool enter;

    void Update()
    {
        /////////////////////////////////////////////// INPUT_1
        if (Input.GetKeyDown(KeyCode.Space))
            input_1 = true;
        else if (Input.GetMouseButtonDown(0))
            input_1 = true;
        else
            input_1 = false;

        /////////////////////////////////////////////// WIN
        if (Input.GetKeyDown(KeyCode.W))
            win = true;
        else
            win = false;

        /////////////////////////////////////////////// LOSE
        if (Input.GetKeyDown(KeyCode.L))
            lose = true;
        else
            lose = false;

        /////////////////////////////////////////////// TEST
        if (Input.GetKeyDown(KeyCode.T))
            test = true;
        else
            test = false;

        /////////////////////////////////////////////// SERVICE
        if (Input.GetKeyDown(KeyCode.S))
            service = true;
        else
            service = false;

        /////////////////////////////////////////////// BACK
        if (Input.GetKeyDown(KeyCode.B))
            back = true;
        else if (Input.GetKeyDown(KeyCode.Escape))
            back = true;
        else
            back = false;

        /////////////////////////////////////////////// ENTER
        if (Input.GetKeyDown(KeyCode.Return))
            enter = true;
        else
            enter = false;







    }
}
