using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private CharacterController controlador;

    public float velocidade, alturaPulo, velocidadePulo, gravidade;
    // Start is called before the first frame update
    void Start()
    {
        controlador = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direcao = Vector3.forward * velocidade;

        if(controlador.isGrounded)
        {
            if (controlador.isGrounded)
            {
                velocidadePulo = alturaPulo;
            }
        }
        else
        {
            velocidadePulo -= gravidade;
        }
        direcao.y = velocidadePulo;
  controlador.Move(direcao * Time.deltaTime);
    } 
} 
