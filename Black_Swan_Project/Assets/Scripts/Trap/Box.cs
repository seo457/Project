using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && !DATA.clear)
        {
            Debug.Log("Clear!");
            DATA.stageNum++;
            DATA.playerDie = true;
            DATA.clear = true;
        }
    }
}
