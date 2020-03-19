
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private float jump;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float checkRadius;
    [SerializeField] private int jumpValue;
    [SerializeField] private Rigidbody2D rb;
    private bool isGrounded;
    private int midAirJump;
    // Start is called before the first frame update
    void Start()
    {
        midAirJump = jumpValue;
    }

    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, layerMask);
        if (isGrounded == true)
        {
            midAirJump = jumpValue;
        }
        if (midAirJump > 0 && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jump;
            midAirJump--;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && midAirJump == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jump;
        }
    }
}
