using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Combo_show : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI ScoreText;
    void Start()
    {
        ScoreText.SetText("Combo  :{0}\n",Score.Combo_max);
        Score.Combo_max=0;
    }
}
