using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SkillEffect")]
public class SkillEffectSO : ScriptableObject
{
    public GameObject Skill_Attack_Particle;
    public Attack_Type Skill_Attack_Type;

    public void Skill_Activate() { }

}
