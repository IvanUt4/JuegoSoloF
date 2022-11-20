using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{   
    // Se define cual prefab se usará para disparar.
    public GameObject bulletPrefab;

    // Se define cuál será el punto en el cual el proyectil será generado.
    public Transform origin;
    
    //Se define la fuerza con la cual el proyectil será arrojado.
    public float force;


    // Función la cual instala el proyectil y le añade una fuerza para su desplazamiento.
    public void fire(){
        GameObject bullet = Instantiate(bulletPrefab, origin.position, origin.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(origin.up*force, ForceMode2D.Impulse);
    }
}
