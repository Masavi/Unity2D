using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max;
    int min;
    int guess;

    // Use this for initialization
    void Start () {
        StartGame();
    }

    void StartGame ()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Bienvenido al mago del número, compa");
        Debug.Log("Elige un número, ¡no me digas cuál es!");
        Debug.Log("El número más grande que puedes escoger es " + max);
        Debug.Log("El número más pequeño que puedes escoger es " + min);
        Debug.Log("\nPresiona arriba => Mi número es mayor\n" +
                    "Presiona abajo => Mi número es menor\n" +
                    "Presiona return => Escoge ese número\n");
        max = max + 1;
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Es más grande o más pequeño que... ¿" + guess + "?");
    }

    void PlayAgain()
    {
        Debug.Log("¿Deseas jugar de nuevo? Presiona Return");
        if (Input.GetKeyDown(KeyCode.Return))
            StartGame();
    }

    // Update is called once per frame
    void Update() {

        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {     
            max = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("¡Tu número es " + guess +"! ¡Soy un genio!");
            PlayAgain();
        }


    }
}
