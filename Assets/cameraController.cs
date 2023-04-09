using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public float sens = 100f;

    public Transform body;
    float xRot = 0f;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        float rotx = Input.GetAxisRaw("Mouse X") * sens * Time.deltaTime;
        float roty = Input.GetAxisRaw("Mouse Y") * sens * Time.deltaTime;

        xRot -= roty;
        xRot= Mathf.Clamp(xRot, -90f, 90f);
        transform.localRotation=Quaternion.Euler(xRot,0f,0f);
        body.Rotate(Vector3.up * rotx); 
    }
}
