using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line : MonoBehaviour
{
    public float hDir;
    public float vDir;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject hitObj = collider.gameObject;
        transform.position = new Vector3(hDir, vDir, 0);
    }


}
