using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadItemBoy : MonoBehaviour
{
    public GameObject[] Pelos;

    public GameObject[] Narices;
    public GameObject[] Eyes;

    public GameObject[] Mouth;




    // Start is called before the first frame update
    void Start()
    {
        int ActualPelo = PlayerPrefs.GetInt("SelectedPelos");
        GameObject Pelo = Pelos[ActualPelo];
        Pelo.SetActive(true);

        int ActualNariz = PlayerPrefs.GetInt("SelectedNarices");
        GameObject Nariz = Narices[ActualNariz];
        Nariz.SetActive(true);

        int ActualEye = PlayerPrefs.GetInt("SelectedEyes");

        if (ActualEye >= Eyes.Length)
        {
            ActualEye = 0;
            Debug.Log("Te falta una imagen al array chico");
        }

        GameObject Eye = Eyes[ActualEye];
       Eye.SetActive(true);

        int ActualMouth = PlayerPrefs.GetInt("SelectedMouthes");
        GameObject Mouthes = Mouth[ActualMouth];
        Mouthes.SetActive(true);

        //int ActualSex = PlayerPrefs.GetInt("Sexs");
        //GameObject Sexs = Sex[ActualSex];
        //Sexs.SetActive(true);



    }



    // Update is called once per frame
    void Update()
    {
        
    }

    public void Debug0()
    {
        Debug.Log("Exit");

    }
}
