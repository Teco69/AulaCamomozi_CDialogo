using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public ControleDialogo dialogo;
    public Conversa conversa;
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            dialogo.iniciaDialogo(conversa);
        }
    }
}
