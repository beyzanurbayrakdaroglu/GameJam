using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverController : MonoBehaviour
{
    public Animator LeverDownAnimation;
    [SerializeField]private  GameObject door;
    private SecondDoorController _secondDoorController;
    private bool isLeverDown;

    private void Start()
    {
        _secondDoorController = door.GetComponent<SecondDoorController>();
    }

    private void OnMouseDown()
    {
        LeverDownAnimation.SetTrigger("isClicked");
        if (!isLeverDown) _secondDoorController.totalLeverDown++;
        isLeverDown = true;
    }
}
