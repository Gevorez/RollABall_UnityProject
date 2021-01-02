using UnityEngine;
using System.Collections;

//Skrypt powstały przed poznaniem animacji. Odpowiedzalny za obrót konkretnego obiektu.
public class RotationSquare : MonoBehaviour
{
    public float RotationSpeed; //Nadanie prędkości obrotu.

    void Update()
    {
        transform.Rotate(Vector3.forward * RotationSpeed * Time.deltaTime); //Uruchomienie obrotu w danym kierunku oraz o prędkość nadaną w zmiennej RotationSpeed.
    }
}