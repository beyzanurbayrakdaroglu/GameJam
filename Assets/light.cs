using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour
{
    public light _Light;
    public float mintime;
    public float maxtime;
    public float timer;
    void start()
    {
        timer=Random.Range(mintime, maxtime);
    }
    void Update() {
        flickerlight();
    }
    void flickerlight()
    {
        if (timer > 0)
        
            timer -= Time.deltaTime;
        if(timer <= 0)
        {
            _Light.enabled = !_Light.enabled;
            timer= Random.Range(mintime, maxtime);
            
        }
        
    }
}
