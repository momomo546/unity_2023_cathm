using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show_license : MonoBehaviour
{
    private GameObject panel;

    void Awake() {
        panel = GameObject.Find("Panel_license");
    }
    void Start(){
        unvisible();
    }

    public void visible(){
        panel.SetActive(true);
    }
    public void unvisible(){
        panel.SetActive(false);
    }
}
