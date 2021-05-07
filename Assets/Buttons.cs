using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

    public Text instructionsText;
    public Button startButton;
    public Button instructionsButton;
    public Button quitButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerClick(string name)
    {
        if (name == "StartButton")
        {
            LoadMain();
        }
        else if (name == "InstructionsButton")
        {
            GetInstructions();
        }
        else if (name == "QuitButton")
        {
            QuitGame();
        }
    }

    public void LoadMain()
    {
        SceneManager.LoadScene("HelloCardboard");
    }

    public void GetInstructions()
    {
        startButton.enabled = false;
        instructionsButton.enabled = false;
        quitButton.enabled = false;
        instructionsText.enabled = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

 


    
}
