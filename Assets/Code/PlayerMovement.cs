using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 8f;
    public float jumpForce = 12f;
    public Transform groundCheck;
    public float groundCheckDistance = 0.12f;
    public Vector2 groundCheckOffset = new Vector2(0f, -0.5f);
    public LayerMask groundLayer;
    private bool isFacingRight = true;
    public bool isInteracting = false;

    public Rigidbody2D rb;
    private float horizInput;
    private bool isGrounded;
    private Animator animator;

    public float fallMult = 2.5f;
    public float smallJumpMult = 2f;
    private float gravity;
    public float jumpDelay = 0.25f;
    private float jumpTimer;

    public InputAction MoveAction;
    public InputAction JumpAction;
    public InputAction InteractAction;

    private float smoothedInput;

    void OnEnable()
    {
        MoveAction.Enable();
        JumpAction.Enable();
        InteractAction.Enable();
    }

    void OnDisable()
    {
        MoveAction.Disable();
        JumpAction.Disable();
        InteractAction.Disable();
    }

    private void Awake()
    {
        enabled = true;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        gravity = rb.gravityScale;
        gameObject.transform.position = BoolHolder.Instance.tempPos;
    }

    void Update()
    {
        Vector2 moveInput = MoveAction.ReadValue<Vector2>();
        horizInput = smoothedInput;

        float target = moveInput.x;
        float lerpSpeed = (target == 0) ? 20f : 5f;
        smoothedInput = Mathf.Lerp(smoothedInput, target, lerpSpeed * Time.deltaTime);

        Flip();

        Vector2 rayOrigin = groundCheck != null ? (Vector2)groundCheck.position : (Vector2)transform.position + groundCheckOffset;
        RaycastHit2D hit = Physics2D.Raycast(rayOrigin, Vector2.down, groundCheckDistance, groundLayer);
        isGrounded = hit.collider != null;

        if (JumpAction.WasPressedThisFrame())
        {
            //AudioManager.Instance.PlaySFX(AudioManager.Instance.jumpSFX);
            jumpTimer = Time.time + jumpDelay;
        }

        if (InteractAction.WasPressedThisFrame())
        {
            StartCoroutine("Interacting");
        }

        //Update animator parameters
        /*if (animator != null)
        {
            animator.SetFloat("MoveInput", Mathf.Abs(horizInput));
            animator.SetBool("IsGrounded", isGrounded);
            animator.SetBool("IsDashing", isDashing);
            animator.SetBool("HasJumped", hasBeenInAir);
        } */
    }

    void FixedUpdate()
    {
        if (rb.linearVelocity.y < 0)
        {
            rb.gravityScale = gravity * fallMult;
        }
        else if (rb.linearVelocity.y > 0 && !JumpAction.IsPressed())
        {
            rb.gravityScale = gravity * smallJumpMult;
        }
        else
        {
            rb.gravityScale = gravity;
        }

        rb.linearVelocity = new Vector2(horizInput * speed, rb.linearVelocity.y);

        if (jumpTimer > Time.time && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            jumpTimer = 0;
        }
    }

    void OnDrawGizmosSelected()
    {
        if (groundCheck != null)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(groundCheck.position, groundCheck.position + Vector3.down * groundCheckDistance);
        }
        else
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(transform.position + (Vector3)groundCheckOffset, transform.position + (Vector3)groundCheckOffset + Vector3.down * groundCheckDistance);
        }
    }

    private void Flip()
    {
        if (isFacingRight && horizInput < 0f || !isFacingRight && horizInput > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    IEnumerator Interacting()
    {
        isInteracting = true;
        yield return new WaitForSeconds(1);
        isInteracting = false;
    }
}
