using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "MoveState", menuName = "States/MoveState")]

public class MovingState : State
{
    public override void OnStateEnter(CharacterController characterController)
    {
    }

    public override void OnStateExit(CharacterController characterController)
    {
    }

    public override void OnStateUpdate(CharacterController characterController)
    {
        Vector3 direction = (characterController.NextDestination -
            characterController.gameObject.transform.position).normalized;
        AnimatorController aController = characterController.gameObject.GetComponent<AnimatorController>();
        aController.SetDirection(direction);
        characterController.gameObject.GetComponent<MoveBehaviour>().Move(characterController.NextDestination);
        aController.SetSpeed(characterController.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude);
    }
}
