using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    int Stage = DATA.stageNum;
    private void Update()
    {
        StartCoroutine(SceneChanger());
    }
    IEnumerator SceneChanger()
    {
        yield return new WaitForSeconds(0.5f);
        switch (Stage)
        {
            case 1:
                SceneManager.LoadScene("Stage01");
                break;
            case 2:
                SceneManager.LoadScene("Stage02");
                break;
            case 3:
                SceneManager.LoadScene("Stage03");
                break;
            case 4:
                SceneManager.LoadScene("Stage04");
                break;
            case 5:
                SceneManager.LoadScene("Stage05");
                break;
        }
        DATA.clear = false;
    }
}
