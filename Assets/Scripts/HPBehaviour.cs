using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPBehaviour : MonoBehaviour , IDamageable
{
    [SerializeField] private int _healthPoints;
    [SerializeField] private CharacterSO _character;
    private void Awake()
    {
        _healthPoints = _character.HP;
    }
    public void OnHurt(int damage)
    {
        _healthPoints = Mathf.Max(_healthPoints-damage,0);
        if (_healthPoints == 0)
            Die();
    }
    public void Die()
    {
        Destroy(gameObject);
    }
}
