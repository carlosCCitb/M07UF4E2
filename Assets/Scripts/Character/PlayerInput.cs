using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerInput : MonoBehaviour, ActMap.IPlayerActions
{
    private ActMap _actMap;
    private PlayerController _playerController;
    public Vector3 MousePosition;
    public Actions LastAction;
    private void Awake()
    {
        LastAction = Actions.Null;
        _actMap = new ActMap();
        _actMap.Player.SetCallbacks(this);
        _playerController = GetComponent<PlayerController>();
    }
    private void OnEnable()
    {
        _actMap.Enable();
    }
    private void OnDisable()
    {
        _actMap.Disable();
    }
    public void OnAttack(InputAction.CallbackContext context)
    {
        if(context.canceled)
        {
            LastAction = Actions.Attack;
        }
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        if(context.canceled)
        {
            LastAction = Actions.Move;
        }
    }
    public void OnMousePosition(InputAction.CallbackContext context)
    {
        MousePosition = context.ReadValue<Vector2>();
        MousePosition = Camera.main.ScreenToWorldPoint(MousePosition);
        MousePosition.z = 0;
        _playerController.MousePosition = MousePosition;
    }
}
