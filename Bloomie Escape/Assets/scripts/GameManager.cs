using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int puntuacionActual, mejorPuntuacion;
    [SerializeField] float tiempo;
    [SerializeField] TMP_Text textoTiempo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        int minutos = (int)tiempo / 60;
        int segundos = (int)tiempo % 60;
        Debug.Log($"{minutos:D2}:{segundos:D2}");
        textoTiempo.text = $"{minutos:D2}:{segundos:D2}"; //Ahora lo pongo esto uwuw
    }
}
