using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantasHerencia: MonoBehaviour
{
    protected int vida;
    BoxCollider2D _comBoxCollider2D;

    public void RecibirDaño(int cantidadDaño)
    {
        vida = vida - cantidadDaño;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
    void Awake()
    {
        _comBoxCollider2D = GetComponent<BoxCollider2D>();
    }

}
