using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_1 : MonoBehaviour
{
    public GameManager gameManager;

    public void Level_1Enter()
    {
        gameManager.nextLevel = 2;
    }
}
