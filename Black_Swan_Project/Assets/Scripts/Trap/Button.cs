using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject onBtn;
    public GameObject offBtn;
    public GameObject tile;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Box")
        {
            offBtn.SetActive(true);
            onBtn.SetActive(false);
            tile.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Box")
        {
            offBtn.SetActive(false);
            onBtn.SetActive(true);
            tile.SetActive(true);
        }
    }
}
