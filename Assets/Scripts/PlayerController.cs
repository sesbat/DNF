using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{ 
    private PlayerInput playerInput;
    private Animator playerAnimator;
    private Rigidbody2D rb2d;

    public float verticalSpeed = 10f;
    public float horizontalSpeed = 20f;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        rb2d = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {

    }

    public void Move()
    {

    }
}
