using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pswrd : MonoBehaviour
{
   [SerializeField] private Text Ans;
    [SerializeField] private Animator Door;
    public bool isPasswordCompleted;

    public string Answer = "342";
    public void Number(int number)
    {
        Ans.text += number.ToString();
    }
    public void Execute()
    {
        if (Ans.text == Answer)
        {
            Ans.text = "Correct";
            Door.SetBool("Open", true);
            StartCoroutine("StopDoor");
            Cursor.lockState = CursorLockMode.Locked;
            gameObject.SetActive(false);
            isPasswordCompleted = true;
        }
        else
        {
            StartCoroutine(StopForText());
        }
    }
    IEnumerator StopDoor()
    {
        yield return new WaitForSeconds(0.5f);
        Door.SetBool("Open", false);
        Door.enabled = false;

    }

    IEnumerator StopForText()
    {
        Ans.text = "Invalid";
        yield return new WaitForSeconds(0.5f);
        Ans.text = "";
        
    }
}
