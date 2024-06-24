using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unitychan_button_anim : MonoBehaviour
{
    private GameObject unitychan;
    private GameObject unitychan_up;
    private GameObject unitychan_down;
    private float time;
    private float time_tmp;
    public float change_time = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        unitychan = GameObject.Find("SD_unitychan_humanoid");
        unitychan_up = GameObject.Find("SD_unitychan_humanoid (1)");
        unitychan_down = GameObject.Find("SD_unitychan_humanoid (2)");
        unitychan_up.SetActive (false);
        unitychan_down.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (Input.GetKeyDown (KeyCode.F)) {
            anim_up();
        }
        if (Input.GetKeyDown (KeyCode.V)) {
            anim_down();
        }
        if (Input.GetKeyDown (KeyCode.N)) {
            anim_down();
        }
        if (Input.GetKeyDown (KeyCode.J)) {
            anim_up();
        }
        if(time-time_tmp>change_time){
            unitychan_up.SetActive (false);
            unitychan_down.SetActive (false);
            unitychan.SetActive (true);
        }
    }

    void anim_up()
    {
        if(unitychan.activeSelf==true){
            unitychan_up.SetActive (true);
            unitychan.SetActive (false);
        }
        else{
            unitychan_up.SetActive (true);
            unitychan_down.SetActive (false);
        }
        time_tmp=time;
    }
    void anim_down()
    {
        if(unitychan.activeSelf==true){
            unitychan_down.SetActive (true);
            unitychan.SetActive (false);
        }
        else{
            unitychan_down.SetActive (true);
            unitychan_up.SetActive (false);
        }
        time_tmp=time;
    }
}
