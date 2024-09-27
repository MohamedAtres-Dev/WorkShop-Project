using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUDView : MonoBehaviour
{
    public TextMeshProUGUI score;

    private void OnEnable()
    {
        PlayerCollision.onCollectCoin += UpdateScore;
    }

    private void OnDisable()
    {
        PlayerCollision.onCollectCoin -= UpdateScore;
    }



    public void UpdateScore()
    {
        score.text = GameManager.instance.currentScore.ToString();
    }
}
