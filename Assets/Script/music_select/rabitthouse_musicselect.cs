using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rabitthouse_musicselect : MonoBehaviour
{
    public Set_false set;
    public void Event()
    {
        setting.bpm = 128f;
        setting.music_time = 166f;
        set.set_false();
        setting.rabbit_house = true;
        SceneManager.LoadScene("Game_Scene");
    }
}
