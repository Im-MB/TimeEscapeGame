using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerification : MonoBehaviour
{
    private static bool answer1;
    private static bool answer2;
    private static bool answer3;
    private static bool answer4;

    


    void Update()
    {
        FinalAnswer();
    }


    public static bool AnswerAction1()
    {

        string answerValue1 = ((Ink.Runtime.StringValue)DialogueManager001.GetInstance().GetVariableState("question1")).value;

        if (answerValue1 == "true") { answer1 = true; } else { answer1 = false; }

        if (answer1 == true){ return true;}
        else{return false;}

        

    }

    public static bool AnswerAction2()
    {

        string answerValue2 = ((Ink.Runtime.StringValue)DialogueManager001.GetInstance().GetVariableState("question2")).value;

        if (answerValue2 == "true") { answer2 = true; } else { answer2 = false; }

        if (answer2 == true){return true;}
        else{return false;}
    }
    public static bool AnswerAction3()
    {
        
        string answerValue3 = ((Ink.Runtime.StringValue)DialogueManager001.GetInstance().GetVariableState("question3")).value;

        if (answerValue3 == "true") { answer3 = true; } else { answer3 = false; }

        if (answer3 == true){ return true;}
        else{  return false;}
    }

    public static bool AnswerAction4()
    {

        string answerValue4 = ((Ink.Runtime.StringValue)DialogueManager001.GetInstance().GetVariableState("question4")).value;

        if (answerValue4 == "true") { answer4 = true; } else { answer4 = false; }

        if (answer4 == true){return true;}
        else{return false;}
    }


    private static bool FinalAnswer()
    {
        if (AnswerAction1() && AnswerAction2() && AnswerAction3() && AnswerAction4())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    

}
