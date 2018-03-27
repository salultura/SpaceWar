using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleAsteroide : MonoBehaviour
{
    public float velocidade = 6;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        SortearSkinDoAsteroide();
        PosicionarAsteroide();
    }

    void FixedUpdate()
    {
        MoverAsteroideParaBaixo();
        RotacionarAsteroide();
    }

    private void PosicionarAsteroide()
    {
        float sorteiaPosicaoEmX = Random.Range(-5.5f, 5.5f);
        transform.position = new Vector3(sorteiaPosicaoEmX, transform.position.y, transform.position.z);
    }

    private void SortearSkinDoAsteroide()
    {
        int sorteiaAsteroide = Random.Range(1, 25);
        transform.GetChild(sorteiaAsteroide).gameObject.SetActive(true);
    }

    private void MoverAsteroideParaBaixo()
    {
        rb.MovePosition(transform.position + Vector3.back * Time.deltaTime * velocidade);
    }

    private void RotacionarAsteroide()
    {
        Quaternion taxaDeRotacao = Quaternion.Euler(new Vector3(15, 30, 45) * Time.deltaTime);
        rb.MoveRotation(rb.rotation * taxaDeRotacao);
    }
}
