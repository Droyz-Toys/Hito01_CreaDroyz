using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSex : MonoBehaviour
{
    public GameObject[] Sexos;
    int ActualSex = 0;



    public void Awake()
    {
        ActualSex = 0;
    }
    public void Start()
    {
        ActualSex = PlayerPrefs.GetInt("Sex");
        Sexos[ActualSex].SetActive(true);
    }

    public void SelectObject(int selectedIndex)
    {

        if (ActualSex >= 0)
            Sexos[ActualSex].SetActive(false);


        ActualSex = selectedIndex;
       Sexos[selectedIndex].SetActive(true);
        PlayerPrefs.SetInt("Sexs", ActualSex);


    }



    public void EquipNariz()
    {
        PlayerPrefs.SetInt("SelectedSex", ActualSex);
    }

    //public void MenuChico()
    //{
    //    SceneManager.LoadScene("MenuChico", LoadSceneMode.Single);
    //}
}
