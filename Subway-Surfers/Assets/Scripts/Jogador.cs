using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
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
            if (Input.GetKeyDown(KeyCode.Space))
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
