using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_show : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI ScoreText;

    // Update is called once per frame
    void Start()
    {
        Score.score = Score.Perfect*500+Score.Great*300+Score.Good*100+Score.Bad*10;
        ScoreText.SetText("Score:{0}\n",Score.score);
        Score.score=0;
    }
}
