using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_show : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI ScoreText;
    [SerializeField]private TextMeshProUGUI ComboText;
    [SerializeField]private TextMeshProUGUI PerfectText;
    [SerializeField]private TextMeshProUGUI GreatText;
    [SerializeField]private TextMeshProUGUI GoodText;
    [SerializeField]private TextMeshProUGUI BadText;
    [SerializeField]private TextMeshProUGUI MissText;

    // Update is called once per frame
    void Start()
    {
        Score.score = Score.Perfect*500+Score.Great*300+Score.Good*100+Score.Bad*10;
        ScoreText.SetText("Score:{0}\n",Score.score);
        Score.score=0;
        
        ComboText.SetText("Combo  :{0}\n",Score.Combo_max);
        Score.Combo_max=0;
        
        PerfectText.SetText("Perfect:{0}\n",Score.Perfect);
        Score.Perfect=0;
        
        GreatText.SetText("Great  :{0}\n",Score.Great);
        Score.Great=0;

        GoodText.SetText("Good   :{0}\n",Score.Good);
        Score.Good=0;

        BadText.SetText("Bad    :{0}\n",Score.Bad);
        Score.Bad=0;

        MissText.SetText("Miss   :{0}\n",Score.Miss);
        Score.Miss=0;
    }
}
