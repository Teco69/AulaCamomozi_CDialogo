using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControleDialogo : MonoBehaviour
{
    public GameObject caixaDialogo;
    public Image Expressao;
    public TextMeshProUGUI nomePersonagem, textoPersonagem;
    public Conversa conversaAtual;
    int indice;
    Queue<string> filaFalas;

    public void iniciaDialogo(Conversa conversa)
    {
        caixaDialogo.SetActive(true);
        filaFalas = new Queue<string>();
        conversaAtual = conversa;
        indice = 0;
        proximaFala();
    }

    public void proximaFala()
    {
        if (filaFalas.Count == 0)
        {
            if (indice < conversaAtual.Falas.Length)
            {
                Expressao.sprite = conversaAtual.Falas[indice].personagem.Expressoes[conversaAtual.Falas[indice].IdExpressao];
                Expressao.SetNativeSize();
                nomePersonagem.text = conversaAtual.Falas[indice].personagem.Nome;
                foreach (string textoFala in conversaAtual.Falas[indice].TextoDasFalas)
                {
                    filaFalas.Enqueue(textoFala);
                }
                indice++;
            }
            else
            {
                caixaDialogo.SetActive(false);
                return;
            }
            }
        textoPersonagem.text=filaFalas.Dequeue();
        }
    }


