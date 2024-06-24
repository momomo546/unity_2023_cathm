using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Good_show : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI ScoreText;
    void Start()
    {
        ScoreText.SetText("Good   :{0}\n",Score.Good);
        Score.Good=0;
    }
}
