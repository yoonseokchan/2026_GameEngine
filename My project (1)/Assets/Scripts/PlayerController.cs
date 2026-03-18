using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    private Vector2 moveInput;
    public float moveSpeed = 7f;
    public float jumpforce = 7f;
    private Rigidbody2D rb;
    private Animator myAnimator;

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        myAnimator= GetComponent<Animator>();
        myAnimator.SetBool("Move",false);
    }
    public void OnJump(InputValue value)
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpforce);
    }

    // Update is called once per frame
    void Update()
    {
        if (moveInput.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if(moveInput.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (moveInput.magnitude > 0)
        {
            myAnimator.SetBool("Move", true);
        }
        else
        {
            myAnimator.SetBool("Move",false) ;
        }
            transform.Translate(Vector3.right * moveSpeed * moveInput.x * Time.deltaTime);
    }
}
