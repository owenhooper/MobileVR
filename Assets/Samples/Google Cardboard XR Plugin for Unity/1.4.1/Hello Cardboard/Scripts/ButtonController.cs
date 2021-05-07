using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ButtonController : MonoBehaviour
{

    public enum button
    {
        start,
        instructions,
        quit,
        back
    }

    public GameObject instructionsCanvas;

    public button chosenButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter()
    {
        GetComponent<Image>().color = Color.gray;
    }


    public void OnPointerExit()
    {
        GetComponent<Image>().color = Color.white;

    }

    public void OnPointerClick()
    {
        switch(chosenButton)
        {
            case button.start:
                LoadMain();
                break;
            case button.instructions:
                instructionsCanvas.SetActive(true);
                break;
            case button.quit:
                QuitGame();
                break;
            case button.back:
                instructionsCanvas.SetActive(false);
                break;
               
        }


    }

    public void LoadMain()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
