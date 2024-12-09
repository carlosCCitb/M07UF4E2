using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State : ScriptableObject
{
    public List<State> StatesToGo;
    public abstract void OnStateEnter(CharacterController characterController);
    public abstract void OnStateUpdate(CharacterController characterController);
    public abstract void OnStateExit(CharacterController characterController);
}
