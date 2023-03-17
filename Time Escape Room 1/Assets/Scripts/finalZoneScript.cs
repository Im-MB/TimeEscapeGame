using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalZoneScript : MonoBehaviour
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
        Debug.Log("khdaam");
        if (Char1IsNear && !dialogueManager.dialogueIsPlaying)
        {
            Debug.Log("ki9ra");

            if (Input.GetKey("t"))
            {
                dialogueManager.EnterDialogueMode(inkJSON, 3);
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

