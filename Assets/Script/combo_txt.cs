using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class combo_txt : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI comboText;

    // Update is called once per frame
    void Update()
    {
        comboText.SetText("{0}",Score.Combo);
        if(Score.Combo>Score.Combo_max)
        {
            Score.Combo_max=Score.Combo;
        }
    }
}
