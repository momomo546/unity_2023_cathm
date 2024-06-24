using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notes_set : MonoBehaviour
{
    public notes_rabbithouse Notes_rabbithouse;
    public notes_Jump_to_Break Notes_Jump_to_Break;
    public notes_Dreaming_Robot Notes_Dreaming_Robot;
    private float bpm;
    private float speed;
    private float quarter_position;
    private float start_time;
    private float position;
    private GameObject clone;
    private GameObject obj_r;
    private GameObject obj_b;
    private GameObject obj_g;
    private GameObject obj_y;
    public List<GameObject> list_object_r = new List<GameObject>();
    public List<float> list_time_r = new List<float>();
    public List<GameObject> list_object_b = new List<GameObject>();
    public List<float> list_time_b = new List<float>();
    public List<GameObject> list_object_g = new List<GameObject>();
    public List<float> list_time_g = new List<float>();
    public List<GameObject> list_object_y = new List<GameObject>();
    public List<float> list_time_y = new List<float>();
    // Start is called before the first frame update
    void Start()
    {
        bpm = setting.bpm;
        speed = setting.speed;
        quarter_position = 60/bpm*speed;
        start_time = setting.start_time;

        obj_r = (GameObject)Resources.Load ("notes_r");
        obj_b = (GameObject)Resources.Load ("notes_b");
        obj_g = (GameObject)Resources.Load ("notes_g");
        obj_y = (GameObject)Resources.Load ("notes_y");

        if(setting.rabbit_house==true){
            Notes_rabbithouse.rabbithouse();
        }
        else if(setting.Dreaming_Robot==true){
            Notes_Dreaming_Robot.Dreaming_Robot();
        }
        else{
            Notes_Jump_to_Break.Jump_to_Break();
        }
    }

    public void notes_r(float bar, float quarter,float eighth ,float sixteenth)
    {
        position = calc_position(bar,quarter,eighth,sixteenth);
        clone = Instantiate(obj_r, new Vector3( start_time*speed+position, 4.5f, -0.1f), Quaternion.Euler (new Vector3(90, 180, 0)));
        list_object_r.Add(clone);
        list_time_r.Add((position+5f)/speed+start_time);
    }
    public void notes_y(float bar, float quarter,float eighth ,float sixteenth)
    {
        position = calc_position(bar,quarter,eighth,sixteenth);
        clone = Instantiate(obj_y, new Vector3( start_time*speed+position, 4.5f, -0.1f), Quaternion.Euler (new Vector3(90, 180, 0)));
        list_object_y.Add(clone);
        list_time_y.Add((position+5f)/speed+start_time);
    }
    public void notes_g(float bar, float quarter,float eighth ,float sixteenth)
    {
        position = calc_position(bar,quarter,eighth,sixteenth);
        clone = Instantiate(obj_g, new Vector3( start_time*speed+position, 1.5f, -0.1f), Quaternion.Euler (new Vector3(90, 180, 0)));
        list_object_g.Add(clone);
        list_time_g.Add((position+5f)/speed+start_time);
    }
    public void notes_b(float bar, float quarter,float eighth ,float sixteenth)
    {
        position = calc_position(bar,quarter,eighth,sixteenth);
        clone = Instantiate(obj_b, new Vector3( start_time*speed+position, 1.5f, -0.1f), Quaternion.Euler (new Vector3(90, 180, 0)));
        list_object_b.Add(clone);
        list_time_b.Add((position+5f)/speed+start_time);
    }
    float calc_position(float bar, float quarter,float eighth ,float sixteenth)
    {
        return quarter_position*bar*4+quarter_position*quarter+quarter_position*eighth/2+quarter_position*sixteenth/4-5f;    
    }

    public void notes_three_r(float bar, float quarter,float eighth ,float sixteenth)
    {
        position = quarter_position*bar*4+quarter_position*quarter*2/3+quarter_position*eighth/3+quarter_position*sixteenth/6-5f;
        clone = Instantiate(obj_r, new Vector3( start_time*speed+position, 4.5f, -0.1f), Quaternion.Euler (new Vector3(90, 180, 0)));
        list_object_r.Add(clone);
        list_time_r.Add((position+5f)/speed+start_time);
    }
    public void notes_three_y(float bar, float quarter,float eighth ,float sixteenth)
    {
        position = quarter_position*bar*4+quarter_position*quarter*2/3+quarter_position*eighth/3+quarter_position*sixteenth/6-5f;
        clone = Instantiate(obj_y, new Vector3( start_time*speed+position, 4.5f, -0.1f), Quaternion.Euler (new Vector3(90, 180, 0)));
        list_object_y.Add(clone);
        list_time_y.Add((position+5f)/speed+start_time);
    }
    public void notes_three_g(float bar, float quarter,float eighth ,float sixteenth)
    {
        position = quarter_position*bar*4+quarter_position*quarter*2/3+quarter_position*eighth/3+quarter_position*sixteenth/6-5f;
        clone = Instantiate(obj_g, new Vector3( start_time*speed+position, 1.5f, -0.1f), Quaternion.Euler (new Vector3(90, 180, 0)));
        list_object_g.Add(clone);
        list_time_g.Add((position+5f)/speed+start_time);
    }
    public void notes_three_b(float bar, float quarter,float eighth ,float sixteenth)
    {
        position = quarter_position*bar*4+quarter_position*quarter*2/3+quarter_position*eighth/3+quarter_position*sixteenth/6-5f;
        clone = Instantiate(obj_b, new Vector3( start_time*speed+position, 1.5f, -0.1f), Quaternion.Euler (new Vector3(90, 180, 0)));
        list_object_b.Add(clone);
        list_time_b.Add((position+5f)/speed+start_time);
    }
    float calc_position_three(float bar, float quarter,float eighth ,float sixteenth)
    {
        return quarter_position*bar*4+quarter_position*quarter*2/3+quarter_position*eighth/3+quarter_position*sixteenth/6-5f;
    }
}
