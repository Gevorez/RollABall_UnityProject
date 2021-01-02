using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Skrypt odpowiedzialny za przełączanie między kamerami.
public class CameraSwitch : MonoBehaviour
{ 
    
    void OnCollisionEnter(Collision collision) //Funkcja OnCollisionEnter która sprawia, że po wejściu na blok odpowiednia kamera zostaje wyłączona a następna włączona, zastępując widok.
    {
        GameObject.Find("CAM1").SetActive(false); //Wyłączenie kamery CAM1
        GameObject.Find("CAM2").SetActive(true);  //Włączenie kamery CAM2
    }
}
