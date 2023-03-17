using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public GameObject teleport;
    public GameObject teleport2;

    
    private bool isAllOn()
    {
        if(AnswerVerification.AnswerAction1() == true && AnswerVerification.AnswerAction2() == true && AnswerVerification.AnswerAction3() == true && AnswerVerification.AnswerAction4() == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "teleport" && isAllOn() == true)
        {
            teleport2.SetActive(true);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "teleport")
        {
            teleport2.SetActive(false);
        }

    }
}
