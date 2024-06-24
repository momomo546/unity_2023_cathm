using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Perfect_show : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI ScoreText;
    void Start()
    {
        ScoreText.SetText("Great  :{0}\n",Score.Great);
        Score.Great=0;
    }
}
