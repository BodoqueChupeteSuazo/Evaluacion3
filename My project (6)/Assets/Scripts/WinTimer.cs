using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WinTimer : MonoBehaviour
{
    // Start is called before the first frame update
    public static float tomer;
    public Text Ventaja;
    private void Update()
    {

       Ventaja.text = "Tiempo Ocupado:" + tomer;
    }

}
