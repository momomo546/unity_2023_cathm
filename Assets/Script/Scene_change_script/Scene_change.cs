using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_change : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.Return)){
            SceneManager.LoadScene("Music_select_Scene");
        }
    }
}
