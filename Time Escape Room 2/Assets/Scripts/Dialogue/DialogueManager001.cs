using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.EventSystems;
using Ink.UnityIntegration;

public class DialogueManager001 : MonoBehaviour
{
    //Start Dialogue Ui// 
    [Header("Dialogue UI")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI dialogueText;
    //End Dialogue UI//

    //Start Choices Ui//
    [Header("Choices UI")]
    [SerializeField] private GameObject[] choices;
    private TextMeshProUGUI[] choicesText;
    //End Choices Ui//

    //Globals Ink Start//
    [Header("Globals Ink File")]
    [SerializeField] private InkFile globalsInkFile; 
    //Globals Ink End//

    private Story currentStory;//Select Our Current Story To Display it//

    private static DialogueManager001 instance;

    public bool dialogueIsPlaying { get; private set; }

    private DialogueVariables dialogueVariables;
    


    private void Awake()
    {
        if(instance != null)
        {
            Debug.Log("Found More Than One Dialogue");
        }
        instance = this;

        //Dialogue Variables Start//
        dialogueVariables = new DialogueVariables(globalsInkFile.filePath);
        //Dialogue Variables END//
    }

    public static DialogueManager001 GetInstance()
    {
        return instance;
    }

    private void Start()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);

        choicesText = new TextMeshProUGUI[choices.Length];

        int index = 0;
        foreach(GameObject choice in choices)
        {
            choicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
            index++;
        }
    }

    private void Update()
    {
        //Return If Dialogue Isn't Playing
        if (!dialogueIsPlaying)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ContinueStory();
        }
        
    }

    public void EnterDialogueMode(TextAsset inkJSON)
    {
        currentStory = new Story(inkJSON.text);
        dialogueIsPlaying = true;
        dialoguePanel.SetActive(true);
        DialogueTrigger001.GetInteract().enabled = false;


        //Dialogue Variables Start//
        dialogueVariables.StartListening(currentStory);//----------
        //Dialogue Variables END//
        

        ContinueStory();

    }

    
    private void ExitDialogueMode() 
    {

        //Dialogue Variables Start//
        dialogueVariables.StopListening(currentStory);
        //Dialogue Variables END//

        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        dialogueText.text = "";
        //Remove The Press E Text
        DialogueTrigger001.GetInteract().enabled = false;
    }

    private void ContinueStory()
    {
        if (currentStory.canContinue)
        {

            dialogueText.text = currentStory.Continue();

            DisplayChoices();
        }
        else
        {
            ExitDialogueMode();
        }
    }

    private void DisplayChoices()
    {
        List<Choice> currentChoices = currentStory.currentChoices;

        if(currentChoices.Count > choices.Length)
        {
            Debug.Log("More choices were given than the UI can support.");
        }
        //******
        int index = 0;
        foreach(Choice choice in currentChoices)
        {
            choices[index].gameObject.SetActive(true);
            choicesText[index].text = choice.text;
            index++;
        }

        for(int i = index;i < choices.Length; i++)
        {
            choices[i].gameObject.SetActive(false);
        }

        
    }
    

    public void MakeChoice(int choiceIndex)
    {
        currentStory.ChooseChoiceIndex(choiceIndex);
    }

    public Ink.Runtime.Object GetVariableState(string variableName)
    {
        Ink.Runtime.Object variableValue = null;
        dialogueVariables.variables.TryGetValue(variableName, out variableValue);
        if( variableValue == null)
        {
            Debug.Log("There is No Answer: " + variableName);
        }

        return variableValue;
    }
}
