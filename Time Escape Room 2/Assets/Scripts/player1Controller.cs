using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1Controller : MonoBehaviour
{

    public float movforce = 3.5f;
    float movx, movy;
    private SpriteRenderer spriteRenderer;
    private Animator playerAnimator;

    private SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (DialogueManager001.GetInstance().dialogueIsPlaying)
        {
            return;
        }
        playerMovement();
        playerAnimation();
    }

    private void playerMovement()
    {
        movx = Input.GetAxis("Horizontal");
        movy = Input.GetAxis("Vertical");
        transform.position += new Vector3(movx, movy) * Time.deltaTime * movforce;
    }


    private void playerAnimation()
    {
        if (movx < 0)
        {
            spriteRenderer.flipX = false;
            
        }
        if (movx > 0)
        {
            spriteRenderer.flipX = true;
        
        }
        


        if (movx != 0 || movy != 0)
        {
            playerAnimator.SetBool("isMove", true);
        }
        else { playerAnimator.SetBool("isMove", false); }
    }


    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        sprite = GetComponent<SpriteRenderer>();

        if (collision.gameObject.tag == "Bridge")
        {
            sprite.sortingOrder = 0;
        }
    }*/
}
