using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ESCMenu : MonoBehaviour
{
    public Animator ani;

    private void Awake()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && DATA.esc == false)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            ani.SetBool("Run", true);
            DATA.esc = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && DATA.esc == true)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            ani.SetBool("Run", false);
            DATA.esc = false;
        }
    }

    public void YBtnClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
    
    public void NBtnClick()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        ani.SetBool("Run", false);
        DATA.esc = false;
    }
}
