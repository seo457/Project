using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelectButton : MonoBehaviour
{
    public Button Btn01;
    public Button Btn02;
    public Button Btn03;
    public Button Btn04;
    public Button Btn05;
    public Button Btn06;
    public Button Btn07;

    public void Btn01Click()
    {
        DATA.stageNum = 1;
        SceneManager.LoadScene("Stage01");
    }

    public void Btn02Click()
    {
        DATA.stageNum = 2;
        SceneManager.LoadScene("Stage02");
    }
}
