using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spike : MonoBehaviour
{
    private void Update()
    {
        if (DATA.stageNum > 1)
        {
            DATA.firstStage = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && DATA.firstStage == true)
        {
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
        DATA.playerDie = true;
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Stage01");
    }
}
