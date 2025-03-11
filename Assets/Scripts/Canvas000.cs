using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Canvas000 : MonoBehaviour
{


    //public int escenaChica;
    //public int escenaChico;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SelectAvatar()
    {
        SceneManager.LoadScene(0);

    }
    public void Main()
    {
        SceneManager.LoadScene(1);

    }

    public void MenuChico()
    {
        SceneManager.LoadScene(1);

    }

    public void Rasgos()
    {
        SceneManager.LoadScene(2);

    }
    public void Genetica()
    {
        SceneManager.LoadScene(3);

    }


public void Ropa()
{
    SceneManager.LoadScene(4);

}
public void Exit()
    {

        Application.Quit();
        Debug.Log("exit");
    }

    public void Inicio()
    {
        SceneManager.LoadScene(0);

    }




}
