using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuManagement : MonoBehaviour
{
    [SerializeField] private GameObject popup;
    [SerializeField] private GameObject popUpInputField;
    [SerializeField] private TMP_InputField inputField;
    ItemCollector item;

    private GameObject highscoreTxt;

    public void Start()
    {
        highscoreTxt = GameObject.Find("HighScoreTxt");
        if (highscoreTxt != null)
            highscoreTxt.GetComponent<Text>().text = $"Highscore : {GameManager.Instance.GetHighScore()}";

        // popUpInputField = GameObject.Find("InputNamePanel");
    }

    public void NewGame()
    {
        // int level = SceneManager.GetActiveScene().buildIndex + 1;

        // SceneManager.LoadScene(level);
        // if (popUpInputField == null)
        // {
        //     Debug.Log("Cannot Open the Pop Up");
        //     return;
        // }
        // else
        // {
        popUpInputField.gameObject.SetActive(true);
        // }
    }

    public void LoadGame()
    {
        GameData data = SaveSystem.LoadPlayer();
        SceneManager.LoadScene(data.level);
    }

    public void SaveGame()
    {
        SaveSystem.SavePlayer();
    }

    public void PauseMenu()
    {
        popup.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeMenu()
    {
        popup.SetActive(false);
        Time.timeScale = 1f;
    }

    public void RestartMenu()
    {
        SceneManager.LoadScene("Scenes/Start Menu");
    }

    public void QuitMenu()
    {
        Application.Quit();
    }

    public void InputName()
    {
        PlayerPrefs.SetString("PlayerName", inputField.text);
        Debug.Log(PlayerPrefs.GetString("PlayerName"));
        int level = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(level);
    }
}