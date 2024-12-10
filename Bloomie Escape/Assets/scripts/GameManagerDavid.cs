using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManagerDavid : MonoBehaviour
{
    [SerializeField] public float tiempo;
    [SerializeField] TMP_Text textoTiempo;

    [SerializeField] GameObject pantallaGameOver;
    [SerializeField] GameObject botonReintentar;

    [SerializeField] GameObject Bloomie;
    [SerializeField] GameObject enemigo;
    [SerializeField] enemigo enemigo1;

    [SerializeField] bool activarCronometro;

    [SerializeField] int puntuacionActual;





    // Start is called before the first frame update
    void Start()
    {
        pantallaGameOver.SetActive(false);
        botonReintentar.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (activarCronometro == true)
        {
            tiempo += Time.deltaTime;
            int minutos = (int)tiempo / 60;
            int segundos = (int)tiempo % 60;

            Debug.Log($"{minutos:D2}:{segundos:D2}");

            textoTiempo.text = $"{minutos:D2}:{segundos:D2}";
        }
    }

    public void perder() 
    { 
        Bloomie.SetActive(false);
        enemigo.SetActive(false);
        pantallaGameOver.SetActive(true);
        botonReintentar.SetActive(true);
        activarCronometro = false;

    }

    public void reiniciarJuego() 
    {
        puntuacionActual = 0;
        Bloomie.SetActive(true);
        enemigo.SetActive(true);
        pantallaGameOver.SetActive(false);
        botonReintentar.SetActive(false);
        tiempo = 0;
        activarCronometro = true;
        enemigo1.iniciarEnemigo();
    }

}
