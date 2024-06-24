using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_static 
{
    public int score;
    public int Perfect;
    public int Great;
    public int Good;
    public int Bad;
    public int Miss;
    public int Combo;
    public int Combo_max;
    void Update()
    {
        if(Combo>Combo_max){
            Combo_max = Combo;
        }
    }
}
