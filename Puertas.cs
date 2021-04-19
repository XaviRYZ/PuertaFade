using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puertas : MonoBehaviour
{
    ///Este Script debe ir al player                                                     ///Funciona si tienes todas las zonas puertas o lugares en la misma Escena

    public Transform PlayerTransform;

    public Transform PosicionFinal;                                                     //posicion a donde ira el jugador al tocar la puerta


    public Image imagenfading;                                                          ///Crea un canvas y en el un Panel en el un UI > imagen lo ajustas el tamaño 
                                                                                        ///y le pones imagen o no igual funciona pero si debes 
                                                                      ///ponerle el alfa en 0 y debe estar siempre activado                          esa imagen del Canvas debe ir aqui


    public int TocandoPuerta;                                                           //para verificar q estas junto a una puerta

   
    ///Estos son los transforms a donde ira el jugador deben ser 2 por puerta                   //nota no son de las puertas son go q tu decides donde estaran
    public Transform Puerta1LadoA;
    public Transform Puerta1LadoB;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && TocandoPuerta == 1)                ///Aqui activamos todo si pulsas la tecla P y estas junto a  una puerta
        {
            StartCoroutine(Ejemplocorutina2());                              ///llamamos a la corrutina q ase la animacion y cambia la posicion                                                
        }
    }

    private void OnTriggerEnter(Collider other)
    {
                                                                         //cada if es un lado de la puerta ocupas 2 por cada puerta
                                                                        ///para no tener q usar muchos if podrias darle a cada puerta un lado contrario con scriptableObjects
        if (other.tag == "Puerta1A")
        { 
            PosicionFinal.position = Puerta1LadoB.position;                //si llegas por el lado A se guarda la posicion del lado B
            TocandoPuerta = 1;                                             //afirma q estamos en la puerta
        }
        if (other.tag == "Puerta1B")
        {
            PosicionFinal.position = Puerta1LadoA.position;                 //Si llegas por el B te manda al lado A 
            TocandoPuerta = 1;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        TocandoPuerta = 0;                                                  //indica q no estas en alguna puerta
    }

    ///Esto crea el efecto al entrar a la puerta
    ///No es la forma correcta pero funciona muy bien
    public IEnumerator Ejemplocorutina2()
    {
     
        yield return new WaitForSeconds(.1f);
        imagenfading.color = new Color(0,0,0, 0.1f);
        yield return new WaitForSeconds(.1f);
        imagenfading.color = new Color(0, 0, 0, 0.2f);
        yield return new WaitForSeconds(.1f);
        imagenfading.color = new Color(0, 0, 0, 0.3f);
        yield return new WaitForSeconds(.1f);
        imagenfading.color = new Color(0, 0, 0, 0.4f);
        yield return new WaitForSeconds(.1f);
        imagenfading.color = new Color(0, 0, 0, 0.5f);
        yield return new WaitForSeconds(.1f);
        imagenfading.color = new Color(0, 0, 0, 0.6f);
        yield return new WaitForSeconds(.1f);
        imagenfading.color = new Color(0, 0, 0, 0.7f);
        yield return new WaitForSeconds(.1f);
        imagenfading.color = new Color(0, 0, 0, 0.8f);
        yield return new WaitForSeconds(.1f);
        imagenfading.color = new Color(0, 0, 0, 0.9f);
        yield return new WaitForSeconds(.1f);
        imagenfading.color = new Color(0, 0, 0, 1f);


        ///aqui debe ir el cambia de posicion           es el punto donde la pantalla esta completamente oscura
        PlayerTransform.position = PosicionFinal.position;                  //mandamos al jugador al otro lado de la puerta
        

        yield return new WaitForSeconds(.8f);                               //este .8f ajusta el tiempo q dura la pantalla completamente en negro
        imagenfading.color = new Color(0, 0, 0, 0.9f);
        yield return new WaitForSeconds(.1f);
        imagenfading.color = new Color(0, 0, 0, 0.8f);
        yield return new WaitForSeconds(.1f);
        imagenfading.color = new Color(0, 0, 0, 0.7f);
        yield return new WaitForSeconds(.1f);
        imagenfading.color = new Color(0, 0, 0, 0.6f);
        yield return new WaitForSeconds(.1f);
        imagenfading.color = new Color(0, 0, 0, 0.5f);
        yield return new WaitForSeconds(.1f);
        imagenfading.color = new Color(0, 0, 0, 0.4f);
        yield return new WaitForSeconds(.1f);
        imagenfading.color = new Color(0, 0, 0, 0.3f);
        yield return new WaitForSeconds(.1f);
        imagenfading.color = new Color(0, 0, 0, 0.2f);
        yield return new WaitForSeconds(.1f);
        imagenfading.color = new Color(0, 0, 0, 0.1f);
        yield return new WaitForSeconds(.1f);
        imagenfading.color = new Color(0, 0, 0, 0f);
    }
}
