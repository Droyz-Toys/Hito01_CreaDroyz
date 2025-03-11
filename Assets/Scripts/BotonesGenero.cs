using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonesGenero : MonoBehaviour
{
//  [SerializeField] GameObject botones;

    [SerializeField] GameObject  sexo;
    [SerializeField] GameObject  complexion;


    [SerializeField] GameObject botonSexo;
    [SerializeField] GameObject botonComplexion;


    // Start is called before the first frame update
    void Start()
    {
        //botones = GameObject.FindGameObjectWithTag("Botones");
       // nose = GameObject.FindGameObjectWithTag("Noses");
       //pelo = GameObject.FindGameObjectWithTag("Pelos");
    }


    public void Sexo()
    {
        botonSexo.SetActive(true);
        sexo.SetActive(true);

        botonComplexion.SetActive(false);
        complexion.SetActive(false);


    }


    public void Complexion()
    {
        botonComplexion.SetActive(true);
        complexion.SetActive(true);

        botonSexo.SetActive(false);
        sexo.SetActive(false);



    }




}
