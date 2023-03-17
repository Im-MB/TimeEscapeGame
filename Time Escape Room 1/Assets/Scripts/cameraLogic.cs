using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraLogic : MonoBehaviour
{
    public float FollowSpeed = 1.5f;
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(target.position.x, target.position.y+2.5f, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed * Time.deltaTime);
    }
}