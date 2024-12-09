using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Character", menuName = "Characters")]
public class CharacterSO : ScriptableObject
{
    public float Speed;
    public float AttackRange;
    public float ReachedPointDistance;
    public int HP;
}
