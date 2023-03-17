using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger001 : MonoBehaviour
{
    //Remove The Press E Text
    private static Text interactUI;


    private static DialogueTrigger001 interact;


    [Header("Ink JSON")]
    [SerializeField] private TextAsset InkJSON;

    private bool playerInRange;

    //Remove The Press E Text
    public static Text GetInteract()
    {
        return interactUI;
    }
    private void Awake()
    {
        playerInRange = false;
        interactUI = GameObject.FindGameObjectWithTag("InteractUI").GetComponent<Text>();
        interactUI.enabled = false;
    }

    private void Update()
    {
        if (Chest.isChestOpen()) 
        { 

        if (playerInRange && !DialogueManager001.GetInstance().dialogueIsPlaying)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                DialogueManager001.GetInstance().EnterDialogueMode(InkJSON);
            }
        }


        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Chest.isChestOpen()) { 
                        if (collision.gameObject.tag == "Player")
                    {
                        interactUI.enabled = true;
                        playerInRange = true;
                    }
         }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (Chest.isChestOpen())

        { 
                if (collision.gameObject.tag == "Player")
            {
                interactUI.enabled = false;
                playerInRange = false;
            }

        }
    }
}
