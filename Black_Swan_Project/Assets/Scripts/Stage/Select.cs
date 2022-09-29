using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Select : MonoBehaviour
{
    public Button begin;
    public void StartButtonClick() 
    {
        SceneManager.LoadScene("All");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    
}
