using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadItem1 : MonoBehaviour
{

    public GameObject[] Sex;

    // Start is called before the first frame update
    void Start()
    {

        int ActualSex = PlayerPrefs.GetInt("Sexs");
        GameObject Sexs = Sex[ActualSex];
        Sexs.SetActive(true);


    }


}
