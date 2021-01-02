using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Drugi skrypt odpowiedzalny za przełączanie kamer.
public class CameraSwitch2 : MonoBehaviour
{
    void OnCollisionEnter(Collision collision) //Funkcja OnCollisionEnter która sprawia, że po wejściu na blok odpowiednie kamera zostaje wyłączona a następna włączona, zastępując widok.
    {
        GameObject.Find("CAM2").SetActive(false); //Wyłączenie kamery CAM2
        GameObject.Find("CAM3").SetActive(true); //Włączenie kamery CAM3
    }
}
