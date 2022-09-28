using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spike : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && DATA.firstStage == true)
        {
            DATA.playerDie = true;
            StartCoroutine(Death());
        }
        else if (other.gameObject.tag == "Player" && DATA.firstStage == false)
        {
            DATA.playerDie = true;
            DATA.clear = true;
        }
    }
    IEnumerator Death()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Stage01");
    }
}
