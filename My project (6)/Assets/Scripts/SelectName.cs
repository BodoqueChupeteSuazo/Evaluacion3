using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectName : MonoBehaviour
{
    public InputField imputext;
    public Text TextoNombre;
    public GameObject botonAceptar;
    private void Awake()
    {
  
    }
   
    public void aceptar()
    {
        PlayerPrefs.SetString("nombre1",imputext.text);
        
    }
}
