using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char1Logic : MonoBehaviour
{

    
    public float movforce = 3.5f;
    float movx, movy;
    private SpriteRenderer spriteRenderer;
    public DialogueManager dialogueManager;
    public GameObject retryCanva;

    public GameObject nextButton;
    private Animator playerAnimator;
  
   public int mode=1;
  
    public bool alive = true;



    private void Awake() {}



    // Start is called before the first frame update
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }




    // Update is called once per frame
    void Update()
    {

        mode = dialogueManager.mode;


        if (mode == 3)
        {
            if (Input.GetKey("f"))
            {
                transform.position = new Vector3(45f, 11f, 0f);
            }
        }

        if (mode == 4)
        {
            if (Input.GetKey("f"))
            {
                Debug.Log("to room 2");
            }
        }




        movx = 0;
        movy = 0;

        if (!alive)
        {
            retryCanva.SetActive(true);
        }
        else
        {
            retryCanva.SetActive(false);
        }

        if (!dialogueManager.dialogueIsPlaying && alive) {           
            playerMovement();       
        }
        playerAnimation();
   
    }





    private void playerMovement(){
        movx = Input.GetAxis("Horizontal");
        movy = Input.GetAxis("Vertical");
        transform.position += new Vector3(movx, movy, 0f) * Time.deltaTime * movforce;
    }




    public void toStep2()
    {
        transform.position = new Vector3(28, 3.5f, 0f);
        nextButton.SetActive(false);
    }


    public void revive()
    {
        alive = true;
        transform.position = new Vector3(50, -2.4f, 0f);
    }


    private void playerAnimation()
    {

        if (alive)
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
                playerAnimator.SetBool("movement", true);
                playerAnimator.SetBool("notmvin", false);
                playerAnimator.SetBool("headoff", false);
            }
            else
            {
                playerAnimator.SetBool("movement", false);
                playerAnimator.SetBool("notmvin", true);
                playerAnimator.SetBool("headoff", false);
            }

        }
        else
        {
            playerAnimator.SetBool("movement", false);
            playerAnimator.SetBool("notmvin", false);
            playerAnimator.SetBool("headoff", true);

        }
}



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "lazer")
        {
            alive = false;    
        }
    }



    private void OnTriggerExit2D(Collider2D collision)
    {

    }







}
