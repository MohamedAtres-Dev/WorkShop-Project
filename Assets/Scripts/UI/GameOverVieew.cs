using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverVieew : MonoBehaviour
{
    public void OnRestartPressed()
    {
        GameManager.instance.RestartGame();
    }
}
