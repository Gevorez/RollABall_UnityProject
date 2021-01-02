using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Skrypt powstały przed poznaniem animacji. Odpowiedzalny za obrót konkretnego obiektu.
public class PlaneRotate : MonoBehaviour
{
    public float RotationSpeed; //Nadanie prędkości obrotu.

    void Update()
    {
        transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime); //Uruchomienie obrotu w danym kierunku oraz o prędkość nadaną w zmiennej RotationSpeed.
    }
}
