using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Skrypt odpowiedzalny za wyświetlanie napisów końcowych po zebraniu ostatniej monety.
public class EndText : MonoBehaviour
{
    public GameObject endTextUI; //Wskazanie konkretnego UI naszego tekstu i przypisane do endTextUI.

    void OnTriggerEnter(Collider collider) //Funkcja OnTriggerEnter która jest Triggerem odpowiedzalnym za wyświetlenie tekstu końcowego w momencie zebrania ostatniej monety.
    {
        endTextUI.SetActive(true); //Aktywacja tekstu.
    }
}
