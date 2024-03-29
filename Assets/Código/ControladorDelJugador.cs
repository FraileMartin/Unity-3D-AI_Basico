﻿using UnityEngine;
using System.Collections;

public class ControladorDelJugador : MonoBehaviour
{ 
    public float velocidad;
    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
            float movimientoHorizontal = Input.GetAxis("Horizontal");
            float movimientoVertical = Input.GetAxis("Vertical");
            Vector3 movimiento = new Vector3(movimientoHorizontal, 0f, movimientoVertical);
            rb.AddForce(movimiento * velocidad);
    }
}


