using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float verticalForce;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        rb.AddForce(Vector3.down * 5, ForceMode.Force);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity= Vector3.zero;
            rb.AddForce(Vector3.up * verticalForce, ForceMode.Impulse);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Muerte"))
        {
            GameManager.Instance.GameOver();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        GameManager.Instance.IncreaseScore();
    }
}
