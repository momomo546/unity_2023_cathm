using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check_txt_destroy : MonoBehaviour
{
    private float time;

    // Update is called once per frame
    void Update()
    {
        time+=Time.deltaTime;
        if(time>0.4f)
        {
            Destroy(this.gameObject);
        }
    }
}
