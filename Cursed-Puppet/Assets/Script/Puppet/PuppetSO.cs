using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Puppet")]
public class PuppetSO : ScriptableObject
{
    public string puppet_Name;
    public int puppet_HP;
    public int puppet_Max_EP;
    public Vector2Int puppet_Min_Max_EP_Per_Attack;
    public float puppet_Auto_Attack_Delay;
    public Attack_Type puppet_Auto_Attack_Type;
    public List<CardSO> puppet_All_Cards;
}
