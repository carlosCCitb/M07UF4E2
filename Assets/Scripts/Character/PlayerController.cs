using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Weapon
{
    Sword,
    Spell
}
public class PlayerController : CharacterController
{
    public Vector3 MousePosition;
    public Weapon Weapon;
    private void Awake()
    {
        NextDestination = transform.position;
    }
    public override void CleanDeadBody()
    {
        
    }
    public override void SetNextDirection()
    {
        NextDestination = MousePosition;
        GoToState<MovingState>();
    }
    public override void DestinationReached()
    {
        GoToState<IdleState>();
    }
    public override void SetLookAt(AnimatorController aController)
    {
        aController.SetDirection((MousePosition - transform.position).normalized);
    }
    private void Update()
    {
        _currentState.OnStateUpdate(this);
        //Debug.Log(_currentState.name);
    }
    public override void AttackFinished()
    {
        GoToState<MovingState>();
    }
    public void GoToState<T>() where T : State
    {
        if(_currentState.StatesToGo.Find(obj => obj is T))
        {
            _currentState.OnStateExit(this);
            _currentState = _currentState.StatesToGo.Find(obj => obj is T);
            _currentState.OnStateEnter(this);
        }
    }
    public override void CastSpell(GameObject spell)
    {
        Transform instantiatePosition = transform.GetChild(0);
        Instantiate(spell, instantiatePosition.position, Quaternion.identity);
    }
}
