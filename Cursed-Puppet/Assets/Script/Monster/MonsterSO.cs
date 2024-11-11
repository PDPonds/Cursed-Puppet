using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Monster")]
public class MonsterSO : ScriptableObject
{
    public string monster_Name;
    public int monster_HP;
    public int monster_Max_EP;
    public Vector2 monster_Min_Max_EP_Per_Attack;
    public float monster_Attack_Delay;
    public Attack_Type monster_Auto_AttackType;
    public List<CardSO> monster_All_Move = new List<CardSO>();
}
