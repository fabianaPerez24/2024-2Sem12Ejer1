using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardMovement : MonoBehaviour
{
    [SerializeField] private float speed;
   
    private void Update()
    {
        transform.position += Vector3.left * Time.deltaTime* speed;
    }
}
