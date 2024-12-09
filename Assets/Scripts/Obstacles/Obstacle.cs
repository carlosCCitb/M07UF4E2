using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private Collider2D[] _colliders;
    public GameObject dummy;
    private void Awake()
    {
        _colliders = GetComponents<Collider2D>();
        int i = 0;
        foreach (Collider2D coll in _colliders)
        {
            if (coll is BoxCollider2D)
                GetBoxVertexs(coll.bounds);
            else if (coll is CircleCollider2D || coll is CapsuleCollider2D)
                GetCircleVertexs();
            else if (coll is PolygonCollider2D || coll is EdgeCollider2D)
                GetPolygonVertexs();
        }
    }
    public void GetBoxVertexs(Bounds bounds)
    {

    }
    public void GetCircleVertexs()
    {

    }
    public void GetPolygonVertexs()
    {

    }
}
