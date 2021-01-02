using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;


public class CameraMove : MonoBehaviour
{
    [SerializeField]
    public GameObject player; //Wskazanie obiektu gracza do zmiennej player.
    private UnityEngine.Vector3 offset;


    //Funkcje odpowiedzialne za podążanie kamery za graczem.
    void Start()
    {
        offset = transform.position - player.transform.position;
    }


    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}