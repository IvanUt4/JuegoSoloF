using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FollowPlayer : MonoBehaviour
{   
    //Variable para determinar la velocidad de los enemigos.

    [SerializeField]
    private float speed;




    // Update is called once per frame
    void Update()
    {   
        //Se busca en la escena el objeto con el tag “Player”.
        GameObject player = GameObject.Find("Player");
        
        //Se calcula la distancia entre el enemigo y el jugador.
        float distance = Vector2.Distance(transform.position, player.transform.position);
        
        //Se calcula la dirección a la que se moverá el enemigo.
        Vector2 direction = player.transform.position - transform.position;


        // Se realiza el movimiento usando la función “MoveTowards”.
        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
    }

    // Se realiza la detección de colisiones.
    private void OnCollisionEnter2D(Collision2D other) {
        
        //Se realiza la comprobación de la colisión y se determina si colisionó con el jugador o no.
        // En caso de ser el jugador se reiniciará la escena y el contador volverá a 0.
        //Si no, el objeto se destruye y se añadirá 1 punto al score del jugador.

        if(other.collider.CompareTag("Player")){
            SceneManager.LoadScene(0);
            Score.scoreValue = 0;
        } else{
            Score.scoreValue ++;
            Destroy(gameObject);
        }
        
    }
}
