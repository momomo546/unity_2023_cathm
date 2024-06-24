using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear_Scean_change : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.Return)){
            SceneManager.LoadScene("Start");
        }
    }
}
