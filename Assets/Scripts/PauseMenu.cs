using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

//Skrypt odpowiedzalny za menu Pauzy w trakcie gry.
public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false; //Nadanie wartości false dla zmiennej GameIsPaused w celu jej późniejszej zmiany. Gdy gramy gra nie jest zapauzowana.
    public GameObject pauseMenuUI; //Wskazanie odpowiedniego UI odpowiedzalnego za pauze.
    
    void Update() //Funkcja przypisująca odpowiedniego funkcje pod klawisz Escape.
    {
        if(Input.GetKeyDown(KeyCode.Escape)) //Warunek wciśnięcia klawisza Escape.
        {
            if (GameIsPaused) //Jeżeli jest gra zapauzowana, to klawisz Escape wznowi rozgrywkę.
            {
                Resume(); //Funkja wznawiająca rozgrywkę.
            }
            else //Jeżeli gra nie jest zapauzowana, to klawisz Escape włączy pauze.
            {
                Pause(); //Funkcja pauzująca rozgrywkę.
            }
        }
    }

    public void Resume() //Funkjca wznawiająca rozgrywkę.
    {
        pauseMenuUI.SetActive(false); //Ustawienie UI pauzy jako false w celu jej usunięcia z ekranu.
        Time.timeScale = 1f; //Wznowienie czasu w rozgrywce.
        GameIsPaused = false; //Zmiana zmiennej GameIsPaused na false.
    }

    void Pause() //Funkcja pauzująca rozgrywkę.
    {
        pauseMenuUI.SetActive(true); //Ustawienie UI pauzy jako true w celu wyświetlenia go na ekranie.
        Time.timeScale = 0f; //Zatrzymanie rozgrywki.
        GameIsPaused = true; //Zmiana zmiennej GameIsPaused na true.
    }

    public void LoadMenu() //Funkcja odpowiedzialna za powrót do głównego Menu z poziomu pauzy.
    {
        Time.timeScale = 1f; //Wznowienie rozgrywki w celu możliwości poruszania się po menu.
        SceneManager.LoadScene("menu"); //Przełączenie do sceny zawierającej Menu.
    }

    public void QuitGame() //Funkcja odpowiedzalna za wyłączenie całej gry.
    {
        Application.Quit(); //Wyłączenie aplikacji.
    }

}
