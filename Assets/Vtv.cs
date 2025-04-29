using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vtv : MonoBehaviour
{
    public string valorPatente;
    public int valorModelo;
    public float kilometrosRecorridos;
    public int vencimientoVtv;
    public int hcPpm;
    float cantidadAños;
    float promedioKm;
    // Start is called before the first frame update
    void Start()
    {
        
        if (valorPatente == null)
        {
            Debug.Log(" valor de patente incompleto, VTV no aprobada");
            return;
        }

        if (valorModelo < 1900 || valorModelo > 2025)
        {
            Debug.Log("modelo invalido, VTV no aprobada");
            return;
        }

        if (kilometrosRecorridos < 0)
        {
            Debug.Log("kilometros invalidos, VTV no aprobada");
            return;
        }

        if (vencimientoVtv > 2025 || vencimientoVtv < valorModelo)
        {
            Debug.Log("vencimiento invalido, VTV no aprobada");
            return;
        }

        if (hcPpm < 5 || hcPpm > 100)
        {
            Debug.Log("HC invalido, VTV no aprobada");
            return;
        }

        cantidadAños = 2025 - valorModelo;

        promedioKm = kilometrosRecorridos / cantidadAños;

        if (promedioKm < 10000)
        {
            Debug.Log("VTV otorgada por dos años");
        }

        else 
        {
            Debug.Log("VTV otorgada por un año");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
