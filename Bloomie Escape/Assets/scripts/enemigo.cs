using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class enemigo : MonoBehaviour
{
    [SerializeField] Camera camara;
    [SerializeField] Vector2 posicionInicial;
    [SerializeField] Vector2 posicionMinima;
    [SerializeField] float velocidad;



    void Start()
    {
        camara = Camera.main;
        posicionMinima = camara.ViewportToWorldPoint(new Vector2(0, 0));
        posicionInicial= transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocidad * Time.deltaTime * Vector2.left);

        if (transform.position.x < posicionMinima.x-1)
        {
            transform.position = posicionInicial;
            if (velocidad <= 25)
            {
                velocidad = velocidad + 1;
            }
            else 
            {
             //do nothing 
            }
        }
    }

    public void iniciarEnemigo() 
    {
        transform.position=posicionInicial;
        velocidad = 10;

    }

}
