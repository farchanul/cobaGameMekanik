using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatewepon : MonoBehaviour
{
    public Transform mousepos;//variable untuk mengambil objek mouse position
    void Start(){
        mousepos = GameObject.Find("MousePos").transform;//mengambil posisi gameobject mousePos
    }
    void Update(){
        Vector3 rotation = mousepos.position - gameObject.transform.position;//variabel untuk membuat rotasi (diambil dari mouse position dikurang object position(object rotasi))
        float rotX = Mathf.Atan2(rotation.z,rotation.y) * Mathf.Rad2Deg - 90;//vaariabl untuk membuat derajat rotasi(diambil dari Tangen(variabel rotation(z,y))selain sumbu rotasi)
        transform.rotation = Quaternion.Euler(rotX,0,0);//membuat rotasi objek sesuai sudud variable rotX
    }
}
