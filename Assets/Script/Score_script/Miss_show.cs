using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Miss_show : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI ScoreText;
    void Start()
    {
        ScoreText.SetText("Miss   :{0}\n",Score.Miss);
        Score.Miss=0;
    }
}
