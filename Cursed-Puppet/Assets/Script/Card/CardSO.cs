using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Card")]
public class CardSO : ScriptableObject
{
    public string card_Name;
    public int card_Cost;
    public PositionType card_Position_Condition;
    public SkillEffectSO card_Skill;

}
