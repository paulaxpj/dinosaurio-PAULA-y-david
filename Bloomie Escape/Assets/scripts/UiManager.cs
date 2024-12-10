using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    [SerializeField] TMP_Text PuntuacionActual, MejorPuntuacion;

    // Update is called once per frame
    void Update()
    {
        PuntuacionActual.text = GameManager.Instancia.PuntuacionActual.ToString();
        MejorPuntuacion.text = GameManager.Instancia.MejorPuntuacion.ToString();
    }
}
