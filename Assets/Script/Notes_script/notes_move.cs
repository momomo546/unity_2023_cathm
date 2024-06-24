using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notes_move : MonoBehaviour
{
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = setting.speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(Time.deltaTime * speed,0,0);
    }
}
