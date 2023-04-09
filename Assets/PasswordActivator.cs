using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasswordActivator : MonoBehaviour
{
    public GameObject passwordScreenCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if(passwordScreenCanvas.GetComponent<pswrd>().isPasswordCompleted) return;
        passwordScreenCanvas.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }
}
