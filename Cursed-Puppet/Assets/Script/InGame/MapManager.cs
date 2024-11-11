using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MapManager : MonoBehaviour
{
    [SerializeField] Button selectThisMapBut;

    private void Start()
    {
        selectThisMapBut.onClick.AddListener(SelectThisMap);
    }

    void SelectThisMap()
    {
        SceneManager.LoadScene(2);
        GameManager.Instance.SwitchGamePhase(GamePhase.PrepareBattleStart);
    }

}
