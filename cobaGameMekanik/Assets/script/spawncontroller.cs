using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawncontroller : MonoBehaviour
{
    public GameObject[] spawnpoint;//membuat array spawnpoint
    public GameObject enemyPrivab;//inisiasi enemy
    int jumlahEnemy;// memasukan jumlah enemy
    void Start(){
        spawnpoint = GameObject.FindGameObjectsWithTag("SpawnPoint");// memasukan spawnpoin ke array
        enemyPrivab = GameObject.Find("enemy"); //memasukan enemy
        jumlahEnemy = 0; //mengisi jumlah awal agar 0
    }

    void Update(){
        SpawnEnemy();//memanggil fungsi spawnEnemy
    }
    //fungsi Spawnenemy
    void SpawnEnemy(){
        if (jumlahEnemy < 5){
            Vector3 randomSpawnPoint = spawnpoint[jumlahEnemy].transform.position; // membuat spawn point dari array
            GameObject enemy = Instantiate(enemyPrivab);// menambah enemy
            enemy.transform.position = randomSpawnPoint; // memindah enemy ke spawn point
            jumlahEnemy++; //menambah jumlah enemy
        }
    }
}
