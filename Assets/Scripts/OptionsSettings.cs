using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

//Skrypt odpowiedzalny za menu Opcji.
public class OptionsSettings : MonoBehaviour
{
    public AudioMixer audioMixer; //Wskazanie AudioMixera który obsługuje głośność gry.

    public void SetVolume(float volume) //Funkcja ustawiająca odpowiednią wartość głośności.
    {
        audioMixer.SetFloat("MasterVolume", volume); //Zmiana wartości audoMixera według wartości volume.
    }
}
