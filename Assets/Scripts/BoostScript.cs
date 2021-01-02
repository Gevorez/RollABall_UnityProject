using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostScript : MonoBehaviour
{
    public AudioSource BoostSound; //Wskazanie odpowiedniego Sounda.

    void Start()
    {
        BoostSound = GameObject.Find("BoostSound").GetComponent<AudioSource>(); //Implementacja dźwięku Boost'a.
    }
  
    void OnCollisionEnter(Collision collision) //Funkcja OnCollisionEnter która dodaje po najechaniu na blok siłę do Playera o wartości 50.0f.
    {
        collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        collision.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * 45, ForceMode.Impulse);
        BoostSound.Play(); //Dźwięk aktywacji Boost'a
    }  

}
