using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour


{
    private SpriteRenderer playerSpriteRenderer;

    private BoxCollider2D collider2D;

    public Animator animator;

    public GameObject swordParent;

    public int damage;

    
    
    void Start()
    {
        playerSpriteRenderer = transform.root.GetComponent<SpriteRenderer>();
        collider2D = GetComponent<BoxCollider2D>();
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            Attack();
        }

        if(playerSpriteRenderer.flipX==true)
        {
            swordParent.transform.rotation = Quaternion.Euler(0,-180,0);
        }
        else
        {
            swordParent.transform.rotation = Quaternion.Euler(0,0,0);
        }



    }

    public void Attack()
    {
        animator.Play("Attack");
        collider2D.enabled=true;
        Invoke("DisableAttack",0.5f);
    }

    private void DisableAttack()
    {
        collider2D.enabled = false;
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            collision.GetComponent<Vida_Enemigo>().Vida -= damage;
        }
    }
    
}