using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Se define la velocidad del personaje.
    [SerializeField]
    private float speed = 10f;


    // Crearemos un objeto rigid body.
    [SerializeField]
    private Rigidbody2D rb;


    // Crearemos un objeto Gun.
    [SerializeField]
    private Gun gun;
    

    // Creamos un vector2 el cual será la dirección en la que apunte el mouse.
    [SerializeField]
    private Vector2 direction;

    [SerializeField]

    // variable la cual guardará la posición del mouse.
    private Vector2 mousePosition;

    void Update()
    {   
        // Verificaremos cada frame si se está pulsando alguna tecla de dirección.
        float X = Input.GetAxisRaw("Horizontal");
        float Y = Input.GetAxisRaw("Vertical");


        // Verificaremos si el botón izquierdo del mouse es pulsado, si es así se dispara un proyectil.
        if(Input.GetMouseButtonDown(0)){
            gun.fire();
        }


        // Verificamos la posición del mouse en pantalla.
        direction = new Vector2(X,Y);
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }


    //Función la cual se actualiza cada frame tomando en cuenta las físicas del juego.
    private void FixedUpdate() {

        // Se ajusta el ángulo del arma tomando en cuenta al jugador.

        rb.velocity = new Vector2(direction.x * speed, direction.y * speed);
        Vector2 directionMouse = mousePosition - rb.position;

        float angle = Mathf.Atan2(directionMouse.y,directionMouse.x) * Mathf.Rad2Deg - 90F;
        rb.rotation = angle;
    }
}
