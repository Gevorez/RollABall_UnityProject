using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Skrypt odpowiedzalny za resetowanie pozycji gracza po kolizji z przeszkodą.
public class CrossCollide : MonoBehaviour
{
    void OnCollisionEnter(Collision collision) //Funkcja OnCollisionEnter wywołująca reset pozycji po kontakcie z obiektem.
    {
        GameObject.Find("Player").transform.position = new Vector3(1, 0, 0); //Ustawienie nowej pozycji obiektu Player po kontakcie z przeszkodą.
    }
}
