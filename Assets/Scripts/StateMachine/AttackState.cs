using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "AttackStateSword", menuName = "States/Attack")]
public class AttackState : State
{
    public override void OnStateEnter(CharacterController characterController)
    {
        characterController.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        AnimatorController aController = characterController.gameObject.GetComponent<AnimatorController>();
        characterController.SetLookAt(aController);
        aController.AttackSword();
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
