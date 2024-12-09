using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "AttackStateSpell", menuName = "States/Spell")]
public class SpellState : State
{
    public GameObject Spell;
    public override void OnStateEnter(CharacterController characterController)
    {
        characterController.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        AnimatorController aController = characterController.gameObject.GetComponent<AnimatorController>();
        characterController.SetLookAt(aController);
        aController.AttackSpell();
        
        characterController.GetComponent<InputActor>().enabled = false;
    }

public override void OnStateExit(CharacterController characterController)
{
    characterController.GetComponent<InputActor>().enabled = true;
}

public override void OnStateUpdate(CharacterController characterController)
{
}
}
