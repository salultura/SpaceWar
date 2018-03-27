using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitesDaTela
{

    private float xMin;
    private float xMax;
    private float zMin;
    private float zMax;

    public LimitesDaTela()
    {
        xMin = -5.8f;
        xMax = 5.8f;
        zMin = -3.5f;
        zMax = 14.0f;
    }

    public float XMin
    {
        get
        {
            return xMin;
        }
    }

    public float XMax
    {
        get
        {
            return xMax;
        }
    }

    public float ZMin
    {
        get
        {
            return zMin;
        }
    }

    public float ZMax
    {
        get
        {
            return zMax;
        }
    }
}
