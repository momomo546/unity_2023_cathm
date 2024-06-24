using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Scene_change : MonoBehaviour
{
    private float time;
    void Update()
    {
        time += Time.deltaTime;
        if(time > setting.start_time+setting.music_time){
            SceneManager.LoadScene("Clear_Scene");
        }
    }
}
