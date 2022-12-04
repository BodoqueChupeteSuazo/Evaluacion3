using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    public CharacterController controller;

    public float velocidad;
    public float velRotacion;

    private bool adelante;
    private bool atras;
    private bool derecha;
    private bool izquierda;
    private bool rotDerecha;
    private bool rotIZquierda;

    void Update()
    {
        if(adelante == true)
        {
            controller.Move(transform.forward * velocidad * Time.deltaTime);
        }

        if(atras==true)
        {
            controller.Move(-transform.forward * velocidad * Time.deltaTime);
        }

        if(derecha == true)
        {
            controller.Move(transform.right * velocidad * Time.deltaTime);
        }

        if(izquierda == true)
        {
            controller.Move(-transform.right * velocidad * Time.deltaTime);
        }

        if(rotDerecha == true)
        {
            transform.Rotate(Vector3.up * velRotacion * Time.deltaTime);
        }

        if(rotIZquierda == true)
        {
            transform.Rotate(-Vector3.up * velRotacion * Time.deltaTime);
        }
    }

    public void HaciaAdelante()
    {
        adelante = true;
    }
    public void HaciaAtras()
    {
        atras = true;
    }

    public void HaciaIzquierda()
    {
        izquierda = true;
    }
    public void HaciaDerecha()
    {
        derecha = true;
    }

    public void RotacionDerecha()
    {
        rotDerecha = true;
    }

    public void RotacionIzquierda()
    {
        rotIZquierda = true;
    }

    public void sinFuncion()
    {
        adelante = false;
        atras = false;
        derecha = false;
        izquierda = false;
        rotDerecha = false;
        rotIZquierda = false;
    }
}
