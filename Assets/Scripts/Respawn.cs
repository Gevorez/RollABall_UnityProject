using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Skrypt odpowiedzalny za respawn Playera po spadku z platform.
public class Respawn : MonoBehaviour
{
    public float threshold; //Zmienna w której będzie deklarowana wysokość po której uruchomiony zostanie skrypt.
 
    void Update()
    {
        if (transform.position.y < threshold) //Sprawdzenie pozycji gracza względem nadanego limitu w zmiennej threshold.
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex); //Uruchomienie ponownie poziomu na którym aktualnie graliśmy.
        }
            
    }
}
