using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Skrypt odpowiedzalny za obrót zbieranych monet.
public class CoinRotation : MonoBehaviour
{
    
    public float CoinRotationSpeed; //Nadanie prędkości obrotu.
 
    void Update()
    {
        transform.Rotate(Vector3.forward * CoinRotationSpeed * Time.deltaTime); //Implementacja obrotu.
    }

}
