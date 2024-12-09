using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "DeathState", menuName = "States/DeathState")]
public class DeathState : State
{
    public override void OnStateEnter(CharacterController characterController)
    {
        characterController.gameObject.GetComponent<AnimatorController>().Die();
    }

    public override void OnStateExit(CharacterController characterController)
    {
        characterController.CleanDeadBody();
    }

    public override void OnStateUpdate(CharacterController characterController)
    {
    }
}
