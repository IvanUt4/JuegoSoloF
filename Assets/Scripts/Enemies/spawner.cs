using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    // Definimos cuál será el tiempo mínimo y máximo de cada spawner.
    public float min,max;
    // Definimos cuál será el punto de origen del spawner.
    public Transform origin;
    
    // Definimos qué prefab queremos que el spawner haga aparecer.
    public GameObject prefab;

    // Al crear el spawner se ejecuta la función “spawn”.
    void Start(){
        Invoke("spawn",.5f);
    }

    /*
    Función la cual genera el elemento Prefab seleccionado anteriormente en el intervalo determinado previamente.

    Se trata de una función recursiva debido a que esta función debe ser ejecutada de forma indefinida.
    */
    void spawn(){
        float timeSpawn = Random.Range(min,max);
        Instantiate(prefab, origin.position, transform.rotation);
        Invoke("spawn", timeSpawn);
    }
}
