using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenNote : MonoBehaviour
{
    [SerializeField] private Image Note;
    private void OnTriggerEnter(Collider other)
    {
        Note.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        Note.enabled = false;
    }
}
