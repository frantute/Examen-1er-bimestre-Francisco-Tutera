using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio : MonoBehaviour
{
    public int entradasdeplatea;
    public int entradasdecampo;

    // Start is called before the first frame update
    void Start()
    {
        int precioecampo = entradasdecampo * 1600;
        int precioeplatea = entradasdeplatea * 2000;
        int preciototal = precioecampo + precioeplatea; 
        int entradaslibresc = 20400 - entradasdecampo;
        int entradaslibresp = 16200 - entradasdeplatea;
        int entradastotales = entradasdeplatea + entradasdecampo;
        if (entradasdecampo<0 || entradasdeplatea<0 || entradasdecampo>20400 || entradasdeplatea > 16200)
        {
            Debug.Log("No se puede realizar la cuenta");
        }
        else
        {   Debug.Log(" Se recaudo " + precioecampo + " con las entradas de campo y " + precioeplatea + " con las entradas de pltaea y en total se recaudo " + preciototal);
            if (entradasdecampo == 20400)
            {
            Debug.Log("Entradas de campo Sold Out");
            }
            else
            {
            Debug.Log(" Quedaron " + entradaslibresc + " libres en el campo");
            }
        
            if (entradasdeplatea == 16200)
            {
            Debug.Log(" Entradas de platea Sold Out");
            }
            else
            {
            Debug.Log(" Quedaron " + entradaslibresp + " libres en la platea" );
            }
        
            if(entradastotales> 18300)
            {
            Debug.Log(" El festival fue un exito");
            }
            else
            {
            Debug.Log(" Debemos mejorar la convocatoria");
            }

        }
       
      


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
