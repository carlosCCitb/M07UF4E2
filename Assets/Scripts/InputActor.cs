using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Actions
{
    Attack,
    Move,
    Null
}
public class InputActor : MonoBehaviour
{
    private PlayerInput _playerInput;
    private PlayerController _playerController;
    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
        _playerController = GetComponent<PlayerController>();
    }
    private void Update()
    {
        switch (_playerInput.LastAction)
        {
            case Actions.Attack:
                Attack();
                break;
            case Actions.Move:
                Move();
                break;
            default:
                break;
        }
    }
    private void Attack()
    {
        if (_playerController.Weapon is Weapon.Spell)
            _playerController.GoToState<SpellState>();
        else
            _playerController.GoToState<AttackState>(); //equipar y ya
        _playerInput.LastAction = Actions.Null;
    }
    private void Move()
    {
        _playerController.NextDestination = _playerInput.MousePosition;
        _playerController.GoToState<MovingState>();
        _playerInput.LastAction = Actions.Null;
    }
}
