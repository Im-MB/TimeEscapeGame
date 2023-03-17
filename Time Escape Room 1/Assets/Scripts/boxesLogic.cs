using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxesLogic : MonoBehaviour
{
    public DialogueManager dialogueManager;
    bool Char1IsNear = false;
    public TextAsset inkJSON;

    // Start is called before the first frame update
    void Start()
    {
   
}

    // Update is called once per frame
    void Update()
    {
        if (Char1IsNear && !dialogueManager.dialogueIsPlaying)
        {

            if (dialogueManager.mode > 2)
            {
                Debug.Log("u have got the second item");
                return;
            }else if (dialogueManager.mode < 2)
            {
                Debug.Log("u need the first item");
                return;
            }

            if (Input.GetKey("t"))
            {
                dialogueManager.EnterDialogueMode(inkJSON, 2);
            }
        }
        else if (Input.GetKey("e") && dialogueManager.dialogueIsPlaying)
        {
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
