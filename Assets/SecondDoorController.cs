using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondDoorController : MonoBehaviour
{
    public Animator Door;
    public int totalLeverDown;

    private void Start()
    {
        Door = GetComponent<Animator>();
    }

    private void Update()
    {
        if (totalLeverDown == 3)
        {
            Door.SetBool("Open", true);
        }
    }
}
