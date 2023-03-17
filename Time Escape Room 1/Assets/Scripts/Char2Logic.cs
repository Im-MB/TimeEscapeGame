using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char2Logic : MonoBehaviour
{
  
    public GameObject char1;
    public DialogueManager dialogueManager;
    bool Char1IsNear=false;
   public TextAsset inkJSON;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Char1IsNear && !dialogueManager.dialogueIsPlaying)
        {
            if (dialogueManager.mode > 1)
            {
                Debug.Log("u have got the first item");
                return;
            }

               if (Input.GetKey("t"))
            {
                dialogueManager.EnterDialogueMode(inkJSON, 1);
            }
        }
        else if (Input.GetKey("e") && dialogueManager.dialogueIsPlaying) {
            dialogueManager.ExitDialogueMode();
        }



    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "char1")
        {
            Char1IsNear = true;
        }
    }



    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "char1")
        {
       
            Char1IsNear = false;
        }
    }



}
