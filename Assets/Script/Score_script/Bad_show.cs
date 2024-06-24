using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bad_show : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI ScoreText;
    void Start()
    {
        ScoreText.SetText("Bad    :{0}\n",Score.Bad);
        Score.Bad=0;
    }
}
