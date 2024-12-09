using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    public void OnHurt(int Damage);
    public void Die();
}
