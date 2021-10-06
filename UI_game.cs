using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UI_game : MonoBehaviour
{
    public static UI_game instance;
    public GameObject Begingame;
    public GameObject btnUi;
    public GameObject Gamemanafer;
    public GameObject Game_over;
    public GameObject Game_Win;
    public GameObject Pause;
    public GameObject Btn_Pause;
    public GameObject Level;
    public GameObject key_lv1;
    public GameObject key_lv2;
    private void Awake()
    {
        instance = this;
    }
    public void Play_click()
    {
        Begingame.SetActive(false);
        btnUi.SetActive(true);
        Gamemanafer.SetActive(true);
        Pause.SetActive(true);
        Btn_Pause.SetActive(false);
        Game_over.SetActive(false);
        Game_Win.SetActive(false);
        Level.SetActive(false);
    }
    public void pause_click()
    {
        Btn_Pause.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Quit_game()
    {
        Application.Quit();
    }

    public void Level_click()
    {
        Begingame.SetActive(true);
        btnUi.SetActive(false);
        Gamemanafer.SetActive(false);
        Game_over.SetActive(false);
        Btn_Pause.SetActive(false);
        Pause.SetActive(false);
        Game_Win.SetActive(false);
        Level.SetActive(true);
    }
    public void Btn_menu()
    {
        Begingame.SetActive(true);
        btnUi.SetActive(false);
        Gamemanafer.SetActive(true);
        Game_over.SetActive(false);
        Btn_Pause.SetActive(false);
        Pause.SetActive(false);
        Game_Win.SetActive(false);
        Level.SetActive(false);
    }
    public void Btn_continue()
    {

        Btn_Pause.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Btn_level1()
    {
        Begingame.SetActive(false);
        btnUi.SetActive(true);
        Gamemanafer.SetActive(true);
        Pause.SetActive(true);
        Btn_Pause.SetActive(false);
        Game_over.SetActive(false);
        Game_Win.SetActive(false);
        Level.SetActive(false);
    }
}
