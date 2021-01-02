using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

//Skrypt odpowiedzalny za zbieranie monet przez Player'a.
public class Collectible : MonoBehaviour
{
     
    public AudioSource PickUpSound; //Wskazanie odpowiedniego Soundu podnoszenia monety.
    void Start()
    {
        PickUpSound = GameObject.Find("CoinSound").GetComponent<AudioSource>(); //Implementacja dźwięku.
    }
 
    void OnTriggerEnter(Collider collider) //Funkcja OnTriggerEnter która jest Triggerem odpowiedzalnym za zbieranie monet oraz dodanie wartości do Score.
    {
        collider.gameObject.GetComponent<PlayerScript>().Score += 1; //Dodanie wartości 1 do Score po każdorazowym zebraniu monety.
        PickUpSound.Play(); //Odtworzenie dźwięku po zebraniu monety.
        gameObject.SetActive(false); //Wyłączenie obiektu monety w celu usunięcia jej z mapy (zebrania).
    }
}
