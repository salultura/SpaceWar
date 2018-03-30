using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeAsteroides : MonoBehaviour
{
    public GameObject asteroide;
    private float tempoDeCriacao;
    public float tempoDeRespaw = 3;
    // Use this for initialization
    void Start()
    {
        CriarAsteroide();
        tempoDeCriacao = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > tempoDeCriacao + tempoDeRespaw)
        {
            CriarAsteroide();
            tempoDeCriacao += tempoDeRespaw;
        }
    }

    void CriarAsteroide()
    {
        Instantiate(asteroide, transform.position, Quaternion.identity);
    }
}
