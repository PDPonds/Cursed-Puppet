using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] Button startGame_But;

    private void Start()
    {
        startGame_But.onClick.AddListener(StartGame);
    }

    void StartGame()
    {
        GameManager.Instance.SwitchGamePhase(GamePhase.SelectMapPhase);
        SceneManager.LoadScene(1);
    }

}
