using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragon : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;
    int direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(1, 0, 0f) * Time.deltaTime * direction * 10;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "lazer")
        {
           if (spriteRenderer.flipX == false) {
                spriteRenderer.flipX = true;
                direction = -1;
            } else
            {
                direction = 1;
                spriteRenderer.flipX = false;
            }
          
        }
    }



}
