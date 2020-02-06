using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public Canvas canvas;
    public GameObject Second_menu;
    public GameObject Fird_menu;
  

    public void Second_menus()
    {
        Second_menu.SetActive(!Second_menu.activeSelf);
    }

    public void Fird_menus()
    {
        Fird_menu.SetActive(!Fird_menu.activeSelf);
        Second_menu.SetActive(!Second_menu.activeSelf);
    }

    public void Scens()
    {
        SceneManager.LoadScene("XIX");
    }

    public void Scens2()
    {
        SceneManager.LoadScene("XX");
    }


    void Update()
    {
       
    }
}
