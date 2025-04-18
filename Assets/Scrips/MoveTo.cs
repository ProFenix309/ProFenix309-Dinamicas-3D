using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform targetAgent;

    [SerializeField] Animator animator;

    [SerializeField] float tiempoDeEspera;
    float tiempoInicio;
    bool moverse = false;

    [SerializeField] float actionDistans;
    [SerializeField] float distanciaActual;

    [SerializeField] bool onAwake;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        tiempoInicio = Time.time;
    }

    private void Start()
    {
        if (onAwake)
        {
            agent.SetDestination(targetAgent.position);
        }
    }

    void Update()
    {
        //Temporizador para activar el movimiento
        if (!moverse && Time.time - tiempoInicio >= tiempoDeEspera)
        {
            moverse = true;
        }

        if (moverse)
        {
            MoverNPC();
            EjecutarAnimaciones();
        }
    }
    //Mover al personaje de el metodo NavMeshAgent
    void MoverNPC()
    {
        if (!onAwake)
        {
            //.Distance es para dar el objetiva el NPC 
            float _distanciaActual = Vector3.Distance(transform.position, targetAgent.position);
            distanciaActual = _distanciaActual;

            if (_distanciaActual <= actionDistans)
            {
                agent.SetDestination(targetAgent.position);
            }
        }
    }

    //Detectar la velocidad y ejecuatar la animacion
    void EjecutarAnimaciones()
    {
        float velocidad = agent.velocity.magnitude;


        if (velocidad != 0)
        {
            animator.SetBool("IsWalking", true);
        }

        else
        {
            animator.SetBool("IsWalking", false);
        }
    }
}
