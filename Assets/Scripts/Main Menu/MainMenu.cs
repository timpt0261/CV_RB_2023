using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject main;
    [SerializeField] private GameObject options;
    [SerializeField] private GameObject credits;
    [SerializeField] private GameObject songSelection;

    private enum MenuState
    {
        Main,
        Options,
        Credits,
        SongSelection
    }

    private void Start()
    {
        DisplayMenu(MenuState.Main);
    }

    public void DisplayMainMenu()
    {
        DisplayMenu(MenuState.Main);
    }

    public void DisplayOptions()
    {
        DisplayMenu(MenuState.Options);
    }

    public void DisplayCredits()
    {
        DisplayMenu(MenuState.Credits);
    }

    public void PlayLevel(){
        SceneManager.LoadScene("MainPlatform");
    }

    private void DisplayMenu(MenuState state)
    {
        main.SetActive(state == MenuState.Main);
        options.SetActive(state == MenuState.Options);
        credits.SetActive(state == MenuState.Credits);
        songSelection.SetActive(state == MenuState.SongSelection);
    }

    public void Quit()
    {
        Debug.Log("Game quit successfully");
        Application.Quit();
    }
}
