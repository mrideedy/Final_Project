using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public GameObject SelectCharacter;
    public GameObject mainmenu;


    public void OnSelectCharacter()
    {
        SelectCharacter.SetActive(true);
        mainmenu.SetActive(false);
    }

    public void OnPlayButton()
    {
        Scene.LoadScene("LandOfDead");
    }

    public void OnQuitButton()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
}