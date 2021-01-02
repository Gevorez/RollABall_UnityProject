using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Skrypt odpowiedzalny za wszelkie poruszanie się Player'a.
public class Movement : MonoBehaviour
{
    [SerializeField]
    public Vector3 jump;
    public float force; //Nadanie wartości do zmiennej force.
    public float forward; //Nadanie wartości do zmiennej forward.
    public float jumpForce; //Nadanie wartości do zmiennej jumpForce.
    Rigidbody rb; //Zdefiniowanie Rigidbody.
    public bool isGrounded; //Zmienna odpowiedzalna za skok podczas kontaktu z ziemią.
    Vector3 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); //Implementacja Rigidbody.
    }

    void Update()
    {
        MovementUpdate(); //Przywołanie funkcji MovementUpdate.
        JumpUpdate(); //Przywołanie funkcji JumpUpdate.
        jump = new Vector3(0.0f, jumpForce, 0.0f); //Definiowanej zmiennej jump względem wartości nadanej w jumpForce.
        jumpForce = 0.0f;
    }

    void OnCollisionStay(Collision collision) //Funkjca odpowiedzalna za sprawdzenie kontaktu z obiektem w celu możliwości skoku tylko gdy Player ma jakąś kolizje.
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true; //W momencie kolizji zmienna isGrounded przyjmuje wartość true.
        }
        
    }
    void OnCollisionExit(Collision collision) //Funkjca odpowiedzalna za sprawdzenie kontaktu z obiektem w celu możliwości skoku tylko gdy Player ma jakąś kolizje.
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false; //W momencie kolizji zmienna isGrounded przyjmuje wartość true.
        }
    }


    void FixedUpdate() 
    {
        rb.AddForce(direction * forward);
        rb.AddForce(jump, ForceMode.Impulse); 
    }
    public void MovementUpdate() //Funkcja zawierające instrukcje do poruszania się.
    {
        direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

    private void JumpUpdate() //Osobna funkcja odpowiedzalna za skok.
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) //Warunek wciśnięcia spacji oraz sprawdzenia czy isGrouned ma wartość true.
        {
            jumpForce = 4.0f;
        }
    }
}
