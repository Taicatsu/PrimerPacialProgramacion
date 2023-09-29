using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrullar : MonoBehaviour
{
    [SerializeField] private float velocidad;

    [SerializeField] private Transform [] puntosMovimiento;

    [SerializeField] private float distanciaMinima;

    private int numeroAleatorio;

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        numeroAleatorio = Random.Range(0, puntosMovimiento.Length);
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, puntosMovimiento[numeroAleatorio].position, velocidad + Time.deltaTime);

        if(Vector3.Distance(transform.position, puntosMovimiento[numeroAleatorio].position) < distanciaMinima)
        {
            numeroAleatorio = Random.Range(0,puntosMovimiento.Length);
            
        }
    }

    
}
