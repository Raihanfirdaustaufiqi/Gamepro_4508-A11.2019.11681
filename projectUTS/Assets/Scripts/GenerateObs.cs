using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObs : MonoBehaviour
{
    int score = 0;
    GUIStyle guiStyle = new GUIStyle();

    public GameObject rocks;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("CreateObstacle", 1f, 1.5f);
    }
    void CreateObstacle()
    {
        score++;
        Instantiate (rocks);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnGUI()
    {
        GUI.color = Color.black;
        guiStyle.fontSize = 40;
        GUI.Label(new Rect(0, 0, 300, 50), "Score: " + score.ToString(), guiStyle);
    }
}
