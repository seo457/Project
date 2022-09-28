using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change : MonoBehaviour
{
    private void Update()
    {
        if (DATA.clear == true)
        {
            SceneManager.LoadScene("SceneChange");
        }
    }
}
