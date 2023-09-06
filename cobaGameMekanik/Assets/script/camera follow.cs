using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public float followspeed = 3f; // kecepatan follow camera
    public Transform target; // variable target

    void Start(){
        target = GameObject.Find("Player").transform;
    }
    void Update()
    {
        Vector3 newpos = new Vector3(15f,target.position.y+5f,target.position.z);
        transform.position = Vector3.Slerp(transform.position,newpos,followspeed*Time.deltaTime);
    }
}
