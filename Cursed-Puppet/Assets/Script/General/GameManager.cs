using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public GamePhase gamePHase;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        UpdateGamePhase();
    }

    public void SwitchGamePhase(GamePhase gamePhase)
    {
        this.gamePHase = gamePhase;
        switch (this.gamePHase)
        {
            case GamePhase.MainMenuPhase:
                break;
            case GamePhase.SelectMapPhase:
                break;
            case GamePhase.UsecardPhase:
                break;
            case GamePhase.BattlePhase:
                break;
        }
    }

    void UpdateGamePhase()
    {
        switch (gamePHase)
        {
            case GamePhase.MainMenuPhase:
                break;
            case GamePhase.SelectMapPhase:
                break;
            case GamePhase.UsecardPhase:
                break;
            case GamePhase.BattlePhase:
                break;
        }
    }

    public bool isGamePhase(GamePhase gamePhase)
    {
        return this.gamePHase == gamePhase;
    }

}

public enum Attack_Type
{
    Attack_Close, Attack_Range,
    Attack_Least_Health, Attack_Highest_Health,
    Attack_All, Attack_All_Other_Faction,
    Attack_Font_Line, Attack_Middle_Verticla_Line, Attack_Back_Line,
    Attack_Top_Line, Attack_Middle_Horizontal_Line, Attack_Down_Line
}

public enum PositionType
{
    Position_Font_Line, Position_Middle_Line, Position_Back_Line
}

public enum GamePhase
{
    MainMenuPhase, SelectMapPhase, UsecardPhase, BattlePhase
}