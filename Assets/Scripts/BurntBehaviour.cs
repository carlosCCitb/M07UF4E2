using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurntBehaviour : MonoBehaviour, IBurnable
{
    [SerializeField] private float _restoreColorTime;
    private Color _color;
    private SpriteRenderer _spriteRenderer;
    private HPBehaviour _hpBehaviour;
    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _color = _spriteRenderer.color;
        _hpBehaviour = GetComponent<HPBehaviour>();
    }
    public void OnBurnt(int damage)
    {
        _hpBehaviour.OnHurt(damage);
        ChangeColor(1);
        StartCoroutine(RestoreColor());
    }
    private IEnumerator RestoreColor()
    {
        yield return new WaitForSeconds(_restoreColorTime);
        ChangeColor(-1);
    }
    private void ChangeColor(int i)
    {
        _color = _color + new Color(i * 0.1f, -i * 0.1f, -i * 0.1f);
        _spriteRenderer.color = _color;
    }
}
