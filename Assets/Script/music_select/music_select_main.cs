using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music_select_main : MonoBehaviour
{
    [SerializeField] GameObject rabbithouse;
    [SerializeField] GameObject jumptobreak;
    [SerializeField] GameObject Dreaming_Robot;
    void Awake()
    {
        rabbithouse.SetActive (setting.rabbit_house);
        jumptobreak.SetActive (setting.jump_to_break);
        Dreaming_Robot.SetActive (setting.Dreaming_Robot);
    }
}
