using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class CharacterController : MonoBehaviour
{
    public Vector3 NextDestination;
    protected Stack<Vector3> _destinationPoints;
    [SerializeField] protected List<State> _states;
    [SerializeField] protected State _currentState;
    public CharacterSO CharacterSO;
    public abstract void CastSpell(GameObject spell);
    public abstract void SetNextDirection();
    public abstract void DestinationReached();
    public abstract void SetLookAt(AnimatorController aController);
    public abstract void CleanDeadBody();
    public abstract void AttackFinished();
}
