using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Colision : MonoBehaviour
{
    public Text Vidas;
    bool dimelo = false;
    public AudioClip perder;
    AudioSource audioSource;
    public GameObject botone;
    // Update is called once per frame
    void Start()
    {
    }
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
  
    void Update()
   { 
    }

        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Meta" && dimelo == false)
        {
            StartCoroutine("win");
            dimelo = true;
            botone.SetActive(false);
        }
    }
    IEnumerator win()
    {
        audioSource.PlayOneShot(perder, 0.7F);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("MainMenu");

    }

}


