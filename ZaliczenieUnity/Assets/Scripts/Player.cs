using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Player : Entity
{
    [Header("Movement")]
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;
    [SerializeField] private bool doubleJump;

    private float xInput;

    [Header("Dash info")]
    [SerializeField] private float dashSpeed;
    [SerializeField] private float dashDuration;
    private float dashTime;

    [SerializeField] private float dashCooldown;
    private float dashCooldownTimer;



    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();

        Movement();
        CheckInput();

        dashTime -= Time.deltaTime;
        dashCooldownTimer -= Time.deltaTime;


        if (isGrounded && !Input.GetButton("Jump"))
        {
            doubleJump = false;
        }

        FlipController();

        AnimationsController();
    }

    private void AnimationsController()
    {
        bool isMoving = rb.velocity.x != 0;

        anim.SetFloat("yVelocity", rb.velocity.y);

        anim.SetBool("isMoving", isMoving);
        anim.SetBool("isGrounded", isGrounded);
        anim.SetBool("isDashing", dashTime > 0);
    }

    private void FlipController()
    {
        if (rb.velocity.x > 0 && !facingRight)
            Flip();

        else if (rb.velocity.x < 0 && facingRight)
            Flip();
    }

    private void CheckInput()
    {
        xInput = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
            Jump();

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            DashAbility();
        }

    }

    private void Jump()
    {
        if (isGrounded || doubleJump)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            doubleJump = !doubleJump;

        }

       

   
    }

    

    private void DashAbility()
    {
        if (dashCooldownTimer < 0)
        {
            dashCooldownTimer = dashCooldown;
            dashTime = dashDuration;
        }
    }

    private void Movement()
    {
        if (dashTime > 0)
        {
            rb.velocity = new Vector2(facingDir * dashSpeed, 0);
        }
        else
        {
            rb.velocity = new Vector2(xInput * moveSpeed, rb.velocity.y);
        }
    }

  


}
