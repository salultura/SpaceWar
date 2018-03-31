using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float velocidade = 5;

    private void FixedUpdate()
    {
        transform.position += (Vector3.forward * velocidade * Time.deltaTime);
    }
}
