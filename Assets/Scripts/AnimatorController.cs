using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    private Animator _animator;
    [SerializeField] private float _triggerTime = 0.5f;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    public void AttackSword()
    {
        _animator.SetBool("Attack", true);
        StartCoroutine(DisableTrigger("Attack"));
    }
    public void AttackSpell()
    {
        _animator.SetLayerWeight(1, 1);
        _animator.SetBool("Attack", true);
        StartCoroutine(DisableTrigger("Attack"));
    }
    public void Die()
    {
        _animator.SetBool("Death", true);
        StartCoroutine(DisableTrigger("Attack"));
    }
    public void SetDirection(Vector2 direction)
    {
        _animator.SetFloat("X", direction.x);
        _animator.SetFloat("Y", direction.y);
    }
    public void SetSpeed(float speed)
    {
        _animator.SetFloat("Speed", speed);
    }
    private IEnumerator DisableTrigger(string name)
    {
        yield return new WaitForSeconds(_triggerTime);
        _animator.SetBool(name, false);
    }
}
