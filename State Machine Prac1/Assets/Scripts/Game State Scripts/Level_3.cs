using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_3 : MonoBehaviour
{
    public GameManager gameManager;
    
    public void Level_3Enter()
    {
        gameManager.nextLevel = 1;
    }
}
