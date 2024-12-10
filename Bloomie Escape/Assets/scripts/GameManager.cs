using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public int PuntuacionActual, MejorPuntuacion;
    [SerializeField] float tiempo;
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

    // Update is called once per frame
    public void Perder()
    {

    }

    public void ReiniciarJuego()
    {

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
}
