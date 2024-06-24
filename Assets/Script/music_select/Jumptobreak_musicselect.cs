using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jumptobreak_musicselect : MonoBehaviour
{
    public Set_false set;
    public void Event()
    {
        setting.bpm = 180f;
        setting.music_time = 122f;
        set.set_false();
        setting.jump_to_break = true;
        SceneManager.LoadScene("Game_Scene");
    }
}
