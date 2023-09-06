using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousepos : MonoBehaviour
{
    public Camera cam; // variable untuk mengambil camera
    public Collider planecollider; // variabel untuk mengambil collider plancollider
    RaycastHit hit; // variable untuk mengambil posisi mouse pada plane
    Ray ray; // variable untuk membuat garis ray sesuai posisi mouse
    void Start(){
        cam = GameObject.Find("MainCamera").GetComponent<Camera>(); // memasukan kamera
        planecollider = GameObject.Find("planclick").GetComponent<Collider>(); // memasukan collider object planclik
    }
    void Update()
    {
        ray = cam.ScreenPointToRay(Input.mousePosition); // membuat garis ray sesuai mouse position
        if (Physics.Raycast(ray, out hit)){
            if (hit.collider == planecollider){  // mengecek hit collider == plan collider
                transform.position = hit.point;  // mengubah posisi game object ke hit.point
            }
        }
        
    }
}
