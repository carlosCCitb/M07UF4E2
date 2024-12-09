using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBehaviour : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    [SerializeField] private float _speed;
    [SerializeField] private float _distanceDifference;
    private CharacterSO _characterSO;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _characterSO = GetComponent<CharacterController>().CharacterSO;
        _speed = _characterSO.Speed;
        _distanceDifference = _characterSO.ReachedPointDistance;
    }
    public void Move(Vector3 destination)
    {
        float distanceDif = (destination - transform.position).magnitude;
        bool canMove = distanceDif > _distanceDifference;
        if (canMove)
        {
            Vector3 directionToMove = (destination - transform.position).normalized;
            _rigidbody.velocity = directionToMove * _speed;
        }
        else
            gameObject.GetComponent<CharacterController>().DestinationReached(); 
    }
}
