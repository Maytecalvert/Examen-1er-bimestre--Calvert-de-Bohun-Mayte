using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalTrainer : MonoBehaviour
{
    public string tipoDeEntrenamiento;
    public int horasDeEntrenamiento;
    int precioCardio = 1000;
    int precioFuerza = 1500;
    int precioRecreativo = 2500;
    float precioConDescuento = 0.9f;
    float precioFinal;
    int horasMaxima = 6;
    int horaMinima = 1;
    string codigoCardio = "Cardio";
    string codigoFuerza = "Fuerza";
    string codigoRecreativo = "Recreativo";
    // Start is called before the first frame update
    void Start()
    {

        if (horasDeEntrenamiento > horasMaxima || horasDeEntrenamiento < horaMinima )
        {
            Debug.Log("Error, no se pueden menos de una hora o más de 6 de entrenamiento");
            return;
        }
        if (tipoDeEntrenamiento != codigoCardio && tipoDeEntrenamiento != codigoFuerza && tipoDeEntrenamiento != codigoRecreativo)
        {
            Debug.Log("Error, ese entrenamiento no existe o no esta disponible");
            return;
        }

        if (tipoDeEntrenamiento == codigoCardio)
        {
            precioFinal = precioCardio * horasDeEntrenamiento;
        }
        else if (tipoDeEntrenamiento == codigoFuerza)
        {
            precioFinal = precioFuerza * horasDeEntrenamiento;
        }
        else if (tipoDeEntrenamiento == codigoRecreativo)
        {
            precioFinal = precioRecreativo * horasDeEntrenamiento;
        }


        Debug.Log("Tu entrenamiento es " + tipoDeEntrenamiento + " lo haras un total de " + horasDeEntrenamiento
            + " y te saldra " + precioFinal + "$");

        if (horasDeEntrenamiento == horasMaxima)
        {
            precioFinal = precioFinal * precioConDescuento;
            Debug.Log("Al contratarnos por 6 horas, tenes un 10% de descuento este sera tu precio con descuento "
                + precioFinal + "$");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
