
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Limite
{
    public float xMin, xMax, zMin, zMax;
}

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    public float velocidade = 10;
    public Limite limite;
    public float anguloRotacao = 5;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        PosicionarJogador();
    }

    void FixedUpdate()
    {
        float eixoX = Input.GetAxis("Horizontal");
        float eixoZ = Input.GetAxis("Vertical");
        Vector3 direcao = new Vector3(eixoX, 0, eixoZ);

        MovimentarNave(direcao);

        AplicarLimitesDaTela();

        RotacionarNaveNoEixoZ(eixoX);
    }

    private void MovimentarNave(Vector3 direcao)
    {
        rb.MovePosition(rb.position + (direcao * velocidade * Time.deltaTime));
    }

    private void AplicarLimitesDaTela()
    {
        rb.position = new Vector3(Mathf.Clamp(rb.position.x, limite.xMin, limite.xMax),
                                    0.0f,
                                    Mathf.Clamp(rb.position.z, limite.zMin, limite.zMax));
    }

    private void RotacionarNaveNoEixoZ(float eixoX)
    {
        // A rotacao da nave baseada conforme o jogador a movimenta pelos lados.
        rb.rotation = Quaternion.Euler(0.0f, 0.0f, eixoX * -anguloRotacao);
    }

    private void PosicionarJogador()
    {
        rb.position = new Vector3(0, 0, 0);
    }
}
