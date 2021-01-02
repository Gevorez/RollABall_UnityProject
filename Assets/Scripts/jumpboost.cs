using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Skrypt odpowiedzalny za JumpBoosta, nadanie siły w celu lepszego skoku.
public class jumpboost : MonoBehaviour
{ 
 
    void OnCollisionEnter(Collision collision) //Funkcja OnCollisionEnter która sprawia, że po wejściu na blok zostanie dodana wartość do zmiennej jumpForce.
    {

        collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        collision.gameObject.GetComponent<Rigidbody>().AddForce(transform.up * 22, ForceMode.Impulse);

    }

}
