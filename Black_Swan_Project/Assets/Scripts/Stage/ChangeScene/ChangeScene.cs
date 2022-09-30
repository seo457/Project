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

        string suffix = $"{Stage}";
        if (suffix.Length < 2)
            suffix = '0' + suffix;

        SceneManager.LoadScene("Stage" + suffix);

        DATA.clear = false;
    }
}
