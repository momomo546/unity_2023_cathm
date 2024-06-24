using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Great_show : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI ScoreText;
    void Start()
    {
        ScoreText.SetText("Perfect:{0}\n",Score.Perfect);
        Score.Perfect=0;
    }
}
