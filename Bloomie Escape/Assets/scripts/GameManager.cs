using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public int PuntuacionActual, MejorPuntuacion;

    [SerializeField] public float tiempo;
    [SerializeField] TMP_Text textoTiempo;

    [SerializeField] GameObject pantallaGameOver;
    [SerializeField] GameObject botonReintentar;

    [SerializeField] GameObject Bloomie;
    [SerializeField] GameObject enemigo;
    [SerializeField] enemigo enemigo1;

    [SerializeField] bool activarCronometro;

    [SerializeField] AudioSource perder;
    [SerializeField] AudioSource musicaFondo;






    public static GameManager Instancia;
    // Start is called before the first frame update
    private void Awake()
    {
        if (Instancia == null)
        {
            Instancia = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        MejorPuntuacion = PlayerPrefs.GetInt("MejorPuntuacion");
    }

    void Start()
    {
        pantallaGameOver.SetActive(false);
        botonReintentar.SetActive(false);

    }

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

    public void Perder()
    {
        Bloomie.SetActive(false);
        enemigo.SetActive(false);
        pantallaGameOver.SetActive(true);
        botonReintentar.SetActive(true);
        activarCronometro = false;
        perder.Play();
        musicaFondo.Stop(); 
        
    }

    public void ActualizarPuntuacion()
    {
        PuntuacionActual++;
        if (PuntuacionActual > MejorPuntuacion)
        {
            MejorPuntuacion = PuntuacionActual;
            PlayerPrefs.SetInt("MejorPuntuacion", MejorPuntuacion);
        }
    }

    public void ReiniciarJuego()
    {
        PuntuacionActual = 0;
        Bloomie.SetActive(true);
        enemigo.SetActive(true);
        pantallaGameOver.SetActive(false);
        botonReintentar.SetActive(false);
        tiempo = 0;
        activarCronometro = true;
        enemigo1.iniciarEnemigo();
    }


}
