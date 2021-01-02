using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Skrypt odpowiedzalny za przełącznie sceny po zebraniu ostatniego elementu na końcu mapy.
public class SceneSwap : MonoBehaviour
{
    void OnTriggerEnter(Collider collider) //Funkcja OnTriggerEnter która jest Triggerem odpowiedzalnym za przełącznie na następną scene po zebraniu monety.
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Załadowanie następnej sceny według buildIndex+1.

    }
}
