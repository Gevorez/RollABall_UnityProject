using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Skrypt odpowiedzalny za wynik gracza.
public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    public int Score; //Zmienna Score przechowująca ilość zebranych monet.
    public int MaxScore; //Zmienna MaxScore przechowująca ilość wszystkcih monet na mapie.
    public Text ScoreText; //Wskazanie tekstu odpowiedzalnego za ScoreText.
    
    void Start()
    {
        MaxScore = GameObject.Find("Coins").transform.childCount; //Liczenie wszystkich monet które są na mapie. 
    }

    void Update()
    {
        TextFunction(); //Przywołanie funkcji odpowiedzalnej za akutalizacje tekstu.
    }

    void TextFunction() //Funkcja odpowiedzalna za aktualizacje tekstu.
    {
        ScoreText.text = "Coins: " + Score + " / " + MaxScore; //Dodanie odpowiednich wartości do tekstu.
    }
}
