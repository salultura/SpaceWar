using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxScrolling : MonoBehaviour
{
    public float velocidade = 1f;
    private float alturaOriginalDaImagem;
    private float alturaRealDaImagem;
    private float escalaDaImagem;
    private Vector3 posicaoInicial;

    // Use this for initialization
    void Awake()
    {
        posicaoInicial = transform.position;
        alturaOriginalDaImagem = GetComponent<SpriteRenderer>().size.y;
        escalaDaImagem = GetComponent<SpriteRenderer>().transform.localScale.y;
        alturaRealDaImagem = alturaOriginalDaImagem * escalaDaImagem;
    }

    // Update is called once per frame
    void Update()
    {
        if (alturaRealDaImagem < Mathf.Abs(transform.position.z - posicaoInicial.z))
        {
            transform.position = posicaoInicial;
        }

        transform.Translate(Vector3.down * velocidade * Time.deltaTime);
    }
}
