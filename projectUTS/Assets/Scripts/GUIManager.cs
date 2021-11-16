using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
    public void OnPlay()
    {
        SceneManager.LoadScene("Main");
    }
    public void Oncredits()
    {
        SceneManager.LoadScene("credits");
    }
    public void Onhelp()
    {
        SceneManager.LoadScene("help");
    }
    public void OnMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
