using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int pontuacaoDoJogador1;
    public int pontuacaoDoJogador2;
    public Text textoDaPontuacao;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AumentarPontucaoDoJogador1()
    {
        pontuacaoDoJogador1 += 1;
        AtualizarTextoDePontuacao();
    }

    public void AumentarPontucaoDoJogador2()
    {
        pontuacaoDoJogador2 += 1;
        AtualizarTextoDePontuacao();
    }

    public void AtualizarTextoDePontuacao()
    {
        textoDaPontuacao.text = pontuacaoDoJogador1 + " X " + pontuacaoDoJogador2;
    }
}
