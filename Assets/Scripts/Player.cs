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

        rb.MovePosition(direcao * velocidade * Time.deltaTime) ;

        rb.position = new Vector3(
                                    Mathf.Clamp(rb.position.x, limite.xMin, limite.xMax),
                                    0.0f,
                                    Mathf.Clamp(rb.position.z, limite.zMin, limite.zMax));

        rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x * -anguloRotacao);
    }

    private void PosicionarJogador()
    {
        rb.position = new Vector3(0, 0, 0);
    }
}
