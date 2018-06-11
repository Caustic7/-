using UnityEngine;

public class PlayerCntr : Unit
{
    public int lives = 100;
    private float speed = 7.0f;
    private float jumpForce = 15.0f;
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sprite;
    private bool isGrounded = false;
    private Arrow arrow;

    private CharState State
    {
        get { return (CharState)anim.GetInteger("State"); }
        set { anim.SetInteger("State", (int)value); }
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponentInChildren<SpriteRenderer>();
        arrow = Resources.Load<Arrow>("Arrow");
    }
    private void FixedUpdate()
    {
        CheckGround();
    }
    private void Update()
    {
        if (Input.GetButton("Horizontal"))
            Run();
        if (isGrounded && Input.GetButtonDown("Jump"))
            Jump();
        if (Input.GetButtonDown("Fire1"))
            Shoot();
    }
    private void Run()
    {
        Vector3 direction = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);
        sprite.flipX = direction.x < 0.0f;
        if (isGrounded)
            State = CharState.Run;
    }
    private void Jump()
    {
        rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        State = CharState.Jump;
    }
    private void Shoot()
    {
        Vector3.position = transform.position;
        Arrow newArrow = Instantiate(arrow, position, arrow.transform.rotation) as Arrow;
        newArrow.Direction = newArrow.transform.right * (sprite.flipX ? -1.0f : 1.0f);
        newArrow.Parent = gameObject;
    }
    private void CheckGround()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 0.3f);
        isGrounded = colliders.Length > 1;
        if (!isGrounded)
            State = CharState.Jump;
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Unit unit = collider.gameObject.GetComponent<Unit>();
        if (unit)
            ReceiveDamage();
    }
}
public enum CharState
{
    Run,
    Jump
}
