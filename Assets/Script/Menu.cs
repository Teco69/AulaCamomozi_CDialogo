using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Biblioteca para gerenciar 

public class Menu : MonoBehaviour
{

    public void iniciar()
    {
        SceneManager.LoadScene("TopDown_RPG");
    }

}
