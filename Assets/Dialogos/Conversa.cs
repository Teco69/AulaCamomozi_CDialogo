using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName="NovoDialogo",menuName="Dialogo/Conversa")]
public class Conversa : ScriptableObject
{
    public FalasDaConversa[] Falas;
    public ControleDialogo dialogo;
}

[System.Serializable]
public class FalasDaConversa
{
    public Personagem personagem;
    public int IdExpressao;

    [TextArea]
    public string[] TextoDasFalas;
}