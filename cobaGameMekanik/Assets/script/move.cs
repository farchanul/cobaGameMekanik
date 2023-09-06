using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.Android;

public class move : MonoBehaviour
{
    public Transform mousepos; // posisi mouse
    public float gaya_dorong; // kekuatanrecoil
    private Rigidbody rb; // rigidbody dari objec ini
    private Vector3 recoil; // arah recoil
    void Start()
    {
        mousepos = GameObject.Find("MousePos").transform;//mengambil posisi gameobject mousePos
        gaya_dorong = 40f; // mengisi gaya dorong
        rb = this.GetComponent<Rigidbody>(); // mengambil rigidbody object ini
    }
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0)){ // mengetahui jika mouse di tekan ke bawah
            recoil = mousepos.position - gameObject.transform.position; // menentukan arah recoil
            recoil = new Vector3(0f,recoil.y,recoil.z).normalized; // membuat posisi recoil menjadi antara -1 sampai 1
            rb.AddForceAtPosition(new Vector3(0,recoil.y,recoil.z) * -gaya_dorong,this.gameObject.transform.position); // memberi gaya recoil pada object
        }
        
    }
   
}
