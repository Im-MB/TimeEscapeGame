using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerLogic : MonoBehaviour
{

   public GameObject perso;
   float chary, movforce=1050, ff=40;
    bool hesalive=true, blazed = false;
   public DialogueManager dialogueManager;
   

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    { 
        chary = perso.transform.position.y;
    
        if (chary <= 1.65f && chary >= 1.35f)
        {
           blazed = true; }

        if (blazed && (dialogueManager.mode < 2))
        {
            transform.position += new Vector3(-0.1f, 0f, 0f) * Time.deltaTime * movforce;
        }
   
    }






    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "leftwall")
        {
            transform.position = new Vector3(41f, 1.75f, 0);
            blazed = false;
        }

        if (collision.gameObject.tag == "char1")
        {
            
            transform.position = new Vector3(41f, 1.75f, 0);
            blazed = false;
        }



    }



}
