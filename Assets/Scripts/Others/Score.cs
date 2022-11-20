using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{   
    // Variable la cual será el score global del jugador.

    public static int scoreValue = 0;
    
    //Variable de tipo Text.

    Text score;
    // Start is called before the first frame update
    void Start()
    {
        // Score tomará el valor del componente “Text”.
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        // El score se actualizará cada frame al valor actual.
        score.text = "Score: "+ (scoreValue/2);
    }
}
