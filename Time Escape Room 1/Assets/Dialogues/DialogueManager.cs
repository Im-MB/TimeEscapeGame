 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.UI;
using System;

public class DialogueManager : MonoBehaviour
{

    private DialogueManager instance;
    public GameObject dialoguePanel;
    public GameObject codeImage;
    public GameObject dialogueChoices;
    public TextMeshProUGUI dialogueText;
   
    public Story currentStory;
    public GameObject[] choices;
    public Sprite code1img;
    public Sprite code2img;
    public Sprite code3img;
    public Sprite code4img;
    public Sprite code5img;
    public Sprite code6img;
    public Sprite code7img;
    public Sprite code8img;
    public Sprite code9img;
    public Sprite code10img;

    public TextMeshProUGUI[] choicesText;
    private int typeDialogue;
    public bool playerAlive = true;
   public bool lazerOff = false;

    public GameObject nextButton;

    public int mode = 1;
    public bool dialogueIsPlaying { get; private set;}





  
    private void Awake()
    {
        instance = this;
    }




    // Start is called before the first frame update
    private void Start()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        codeImage.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        if (dialogueIsPlaying)
        {           
            ContinueStory();
            DisplayChoices();
          
            if (typeDialogue == 1 && mode == 1)
            {
                codeImage.SetActive(true);
                setCodeImage1();
           
            } if (typeDialogue == 2 && mode == 2){
                codeImage.SetActive(true);
                setCodeImage2();
            }
            if (typeDialogue == 3) { codeImage.SetActive(false); }
            
           setModes();
        } 
    }







    private void setModes()
    {
      
        if (currentStory.variablesState["pass"].ToString() == "1")
        {            
            Debug.Log("Winning mode");

            if (typeDialogue == 1)
                {
                dialogueText.text = "The Lazer is turned off";
                codeImage.SetActive(false);
                lazerOff = true;
                mode = 2;                        
                }

            if (typeDialogue == 2)
            {
                dialogueText.text = "You can press F to teleport to the other side";
                codeImage.SetActive(false);
                mode = 3;
            }

            if (typeDialogue == 3)
            {
                dialogueText.text = "Congratulations hero you unlocked era 2";
                mode = 4;
            }
        }
            
        if (currentStory.variablesState["pass"].ToString() == "4")
        {
            Debug.Log("losing mode");
            codeImage.SetActive(false);

        }
    }







    private void setCodeImage1()
    {

        if (currentStory.variablesState["code"].ToString() == "1")
        {
            codeImage.GetComponent<Image>().sprite = code1img;
        }

        if (currentStory.variablesState["code"].ToString() == "2")
        {
            codeImage.GetComponent<Image>().sprite = code2img;
        }

        if (currentStory.variablesState["code"].ToString() == "3")
        {
            codeImage.GetComponent<Image>().sprite = code3img;
        }

        if (currentStory.variablesState["code"].ToString() == "4")
        {
            codeImage.GetComponent<Image>().sprite = code4img;
        }

        if (currentStory.variablesState["code"].ToString() == "5")
        {
            codeImage.GetComponent<Image>().sprite = code5img;
        }
    }




    private void setCodeImage2()
    {

        if (currentStory.variablesState["code"].ToString() == "1")
        {
            codeImage.GetComponent<Image>().sprite = code6img;
        }

        if (currentStory.variablesState["code"].ToString() == "2")
        {
            codeImage.GetComponent<Image>().sprite = code7img;
        }

        if (currentStory.variablesState["code"].ToString() == "3")
        {
            codeImage.GetComponent<Image>().sprite = code8img;
        }

        if (currentStory.variablesState["code"].ToString() == "4")
        {
            codeImage.GetComponent<Image>().sprite = code9img;
        }

        if (currentStory.variablesState["code"].ToString() == "5")
        {
            codeImage.GetComponent<Image>().sprite = code10img;
        }
    }






    public void EnterDialogueMode(TextAsset inkJSON, int typd)
    {
        currentStory = new Story(inkJSON.text); 
        dialogueIsPlaying = true;
        dialoguePanel.SetActive(true);
        typeDialogue = typd;
    }


    public void ContinueStory() {
        if (currentStory.canContinue)
        {
            dialogueText.text = currentStory.Continue();
        }       
    }



    public void ExitDialogueMode()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
    }




    public void DisplayChoices()
    {       
        List<Choice> currentChoices = currentStory.currentChoices;
        int index = 0;        
        foreach (Choice choice in currentChoices)
        {
            choicesText[index].text = choice.text;
            index++;
        }
    }


    public void MakeChoice(int choiceIndex)
    {
        currentStory.ChooseChoiceIndex(choiceIndex);      

    }

}