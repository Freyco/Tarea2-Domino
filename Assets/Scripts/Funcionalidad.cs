using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Funcionalidad : MonoBehaviour
{
    public void IrALaPantallaDeJuego()
    {
        SceneManager.LoadScene("Juego");
    }
}

