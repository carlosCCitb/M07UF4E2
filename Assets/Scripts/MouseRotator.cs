using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotator : MonoBehaviour
{
    void Update()
    {
        Vector3 mousepos = transform.parent.GetComponent<PlayerInput>().MousePosition;
        Vector3 dir = (mousepos - transform.position).normalized;
        float angle = Mathf.Atan2(dir.y, dir.x);
        transform.rotation = Quaternion.Euler(new Vector3(1, 1, angle*180f/Mathf.PI - 90f));
    }
}
