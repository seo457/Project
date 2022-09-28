using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // �÷��̾� ����, x ��������

    bool on = false;

    private void Update()
    {
        if (on == true && Input.GetKeyDown(KeyCode.X))
        {
            DATA.firstStage = false;
            Debug.Log("X");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            on = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            on = false;
        }
    }
}
