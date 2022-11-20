using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Detecta si hubo una colisión contra la bala.
    private void OnCollisionEnter2D(Collision2D other) {
     Destroy(gameObject);   
    }
}
