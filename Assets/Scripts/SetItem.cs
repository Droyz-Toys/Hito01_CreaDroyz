using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetItem : MonoBehaviour
{
    public GameObject[] Pelos;
    int ActualPelo = -2;

    // Start is called before the first frame update
    void Start()
    {
        ActualPelo = PlayerPrefs.GetInt("SelectedPelos");
        Pelos[ActualPelo].SetActive(true);

    }

    // Update is called once per frame
   public void NextPelo()
    {
        Pelos[ActualPelo].SetActive(false);
        ActualPelo = (ActualPelo + 1) % Pelos.Length;
        Pelos[ActualPelo].SetActive(true);
    }

    public void PreviousPelo()
    {
        Pelos[ActualPelo].SetActive(false);
        ActualPelo--;
        if ( ActualPelo < 0)
        {
            ActualPelo += Pelos.Length;
        }

        Pelos[ActualPelo].SetActive(true);
    }


    public void EquipPelo()
    {
        PlayerPrefs.SetInt("SelectedPelos", ActualPelo);
    }

    public void MenuChico()
    {
        SceneManager.LoadScene("MenuChico", LoadSceneMode.Single);
    }

}
