using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bridge : MonoBehaviour
{
    public Transform destination;

    public bool isFace1;
    public float distance = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        if(isFace1 == false)
        {
            destination = GameObject.FindGameObjectWithTag("Face1").GetComponent<Transform>();
        }    else
        {
            destination = GameObject.FindGameObjectWithTag("Face2").GetComponent<Transform>();
        }
    }

    /// <summary>
    /// fffffffffffffffffffffff
    /// fdvfd
    /// </summary>
    /// <param name="other">The Other Collider2d involved in this collision</param>



    private void OnTriggerEnter2D(Collider2D other)
    {
        if(Vector2.Distance(transform.position,other.transform.position) > distance)
        {
            other.transform.position = new Vector2(destination.position.x, destination.position.y);
        }
    }


}
