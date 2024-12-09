using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "IdleState", menuName = "States/IdleState")]
public class IdleState : State
{
    public override void OnStateEnter(CharacterController characterController)
    {
        characterController.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }

    public override void OnStateExit(CharacterController characterController)
    {
    }

    public override void OnStateUpdate(CharacterController characterController)
    {
        characterController.SetLookAt(characterController.gameObject.GetComponent<AnimatorController>());
    }
}
