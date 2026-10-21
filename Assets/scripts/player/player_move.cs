
using UnityEngine;

public class player_move:MonoBehaviour 
{
    public float speed = 5f;
    private float x;
    private float y;
    private Rigidbody2D _rb;
    private Animator animator;
    private GunToMouse gunToMouse;
   
        private void Start()
    {
       
        gunToMouse = GetComponentInChildren<GunToMouse>();
       
        animator = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {   SpriteRenderer sr=GetComponent<SpriteRenderer>();
        
        if (gunToMouse .directionX <-0.1f)
        {
            sr.flipX = true;
        }
        else if (gunToMouse .directionX>0.1f)
        {
            sr.flipX = false;
        }
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        Vector2 moveinput = new Vector2(x, y);
        if (moveinput.sqrMagnitude > 1f)
        {
            moveinput.Normalize();
        }
        _rb.linearVelocity = moveinput * speed;
        if(moveinput !=Vector2 .zero )
        {
            animator.SetBool("Run", true);
        }
        else
        {
            animator.SetBool("Run", false);
        }
        Debug.Log("当前速度=" + _rb.linearVelocityX + "," + _rb.linearVelocityY);
    }

}
