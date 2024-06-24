using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DreamingRobot_musicselect : MonoBehaviour
{
    public Set_false set;
    public void Event()
    {
        setting.bpm = 110f;
        setting.music_time = 126f;
        set.set_false();
        setting.Dreaming_Robot = true;
        SceneManager.LoadScene("Game_Scene");
    }
}
