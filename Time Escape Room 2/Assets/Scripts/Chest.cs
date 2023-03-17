using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chest : MonoBehaviour
{

    private Text interactUI;
    private bool isInRange;
    private static bool isOpen;

    public Animator animator;
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    void Awake()
    {
        interactUI = GameObject.FindGameObjectWithTag("InteractUI").GetComponent<Text>();
        visualCue.SetActive(false);
        isOpen = false;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isInRange )
        {
            OpenChest();
        }
    }

    void OpenChest()
    {
        animator.SetTrigger("OpenChest");
        visualCue.SetActive(true);
        isOpen = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && isOpen == false)
        {
            interactUI.enabled = true;
            isInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interactUI.enabled = false;
            isInRange = false;
        }
    }

    public static bool isChestOpen()
    {        
         return isOpen;
    }

}
