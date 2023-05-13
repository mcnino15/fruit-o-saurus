using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    
    float horizontalMove = 0f;
    [SerializeField]private float runSpeed = 15f;
    [SerializeField] private GameObject menuPregunta;
    private bool m_FacingRight = true;
    public Transform Groundcheck;
    public float RadioChecker;
    public bool touchGround;
    public LayerMask m_WhatIsGround;
    private Rigidbody2D rdb;
    public Animator animator;

    
    
    // Start is called before the first frame update
    void Start()
    {
        rdb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        menuPregunta.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
       
        
       horizontalMove = Input.GetAxisRaw("Horizontal") ;
       rdb.velocity = new Vector2(runSpeed * horizontalMove, rdb.velocity.y); 
       
       touchGround = Physics2D.OverlapCircle(Groundcheck.position, RadioChecker, m_WhatIsGround);
       animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        if (horizontalMove > 0 && !m_FacingRight)
        {
            // ... flip the player.
            Flip();
        }
        // Otherwise if the input is moving the player left and the player is facing right...
        else if (horizontalMove < 0 && m_FacingRight)
        {
            // ... flip the player.
            Flip();
        }
    }
    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        m_FacingRight = !m_FacingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
    void FixedUpdate ()
    {
        
        
    }

    void OnCollisionEnter2D(Collision2D col) 
    {
         if (col.gameObject.tag == "Meteo")
        {
            Die();
            Pausa();
            Destroy(col.gameObject);
            menuPregunta.SetActive(true);
           
        }
    }
    private void Die()
    {
        animator.SetTrigger("death");
    }
    public void Pausa ()
    {
        Time.timeScale = 0f;
    }

}
