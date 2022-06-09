using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_2 : MonoBehaviour
{
    public GameManager gameManager;

    public void Level_2Enter()
    {
        gameManager.nextLevel = 3;
    }
}
