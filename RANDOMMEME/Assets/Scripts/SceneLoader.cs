using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
   
    public void LoadGamePlay()
    {
        Application.LoadLevel("Gameplay");
    }
    public void LoadSettings()
    {
        Application.LoadLevel("Settings");
    }
    public void LoadMore()
    {
        Application.LoadLevel("More");
    }
    public void LoadUpMem()
    {
        Application.LoadLevel("UpMem");
    }
    public void LoadDownMem()
    {
        Application.LoadLevel("DownMem");
    }
    public void LoadMainMenu()
    {
        Application.LoadLevel("MainMenu");
    }
    public void LoadList()
    {
        Application.LoadLevel("List");
    }

}
