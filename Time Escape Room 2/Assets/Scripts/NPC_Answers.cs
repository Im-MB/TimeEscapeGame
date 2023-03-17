using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Answers : MonoBehaviour
{
    public  GameObject NPC2;
    public  GameObject NPC3;
    public  GameObject NPC4;


    // Update is called once per frame
    void Update()
    {
        isAnswer1();
        isAnswer2();
        isAnswer3();
    }

    private  void isAnswer1()
    {
        if (AnswerVerification.AnswerAction1() == true) { NPC2.SetActive(true); }
        else if(AnswerVerification.AnswerAction1() == false) { NPC2.SetActive(false); }
    }

    private void isAnswer2()
    {
        if (AnswerVerification.AnswerAction2() == true) { NPC3.SetActive(true); }
        else if (AnswerVerification.AnswerAction2() == false) { NPC3.SetActive(false); }
    }

    private void isAnswer3()
    {
        if (AnswerVerification.AnswerAction3() == true) {  NPC4.SetActive(true); }
        else if (AnswerVerification.AnswerAction3() == false) {  NPC4.SetActive(false); }
    }

    
}
