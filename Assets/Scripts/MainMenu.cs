using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Skrypt odpowiedzalny za działanie Menu
public class MainMenu : MonoBehaviour
{
   public void PlayGame() //Funkcja odpowiedzalna za włączenie następnej sceny.
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Załadowanie następnej sceny według buildIndex+1.
    }

    public void QuitGame() //Funkcja odpowiedzalna za wyjście z gry.
    {
        Debug.Log("Quit!"); //Komunikat w konsoli.
        Application.Quit(); //Wyłączenie aplikacji.
    }
}
