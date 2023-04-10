using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Validation : MonoBehaviour
{
    public InputField txtNombre;

    public Text textNombre;
    public Image img;   
    public GameObject btnAceptar;

    private void Awake()
    {
        img.color = Color.red;
    }

    private void Update()
    {
        if (textNombre.text.Length<3)
        {
            img.color = Color.red;
            btnAceptar.SetActive(false);
        }

        if (textNombre.text.Length >= 3)
        {
            img.color = Color.green;
            btnAceptar.SetActive(true); 
        }
    }

    public void Aceptar()
    {
        PlayerPrefs.SetString("NombrePlayer", txtNombre.text);
        SceneManager.LoadScene("MainScene");
    }
}
