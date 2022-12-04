using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    [SerializeField] int min, seg;
    [SerializeField] Text Tiempo;
    public int timer2;
    private float restante;
    bool dimelo = false;
    private bool enMarcha;
    public AudioClip perder;
    public AudioClip ambiente;
    public AudioClip ganar;
    AudioSource audioSource;
    AudioSource audioSource1;
    AudioSource audioSource2;
    public GameObject botone;
    public int count1 ;
    private void Awake()
    {
        count1 = 0;
        restante = (min * 60) + seg;
        timer2 = (min * 60) + seg;
        enMarcha = true;
        audioSource = GetComponent<AudioSource>();
        audioSource1 = GetComponent<AudioSource>();
        audioSource2 = GetComponent<AudioSource>();
        audioSource1.PlayOneShot(ambiente, 0.7F);
    }
    public void silencio()
        {
        audioSource1.Stop();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Meta" && count1 == 0)
        {

            silencio();
            audioSource2.PlayOneShot(ganar, 0.7F);
            count1 = 0;
            restante =+ 5;
            botone.SetActive(false);
        }
    }
    private void Update()
    {
        if (enMarcha)
        {
           
            restante -= Time.deltaTime;

            if (restante < 1 && dimelo == false)
            {
                StartCoroutine("gameover");
                dimelo = true;
                botone.SetActive(false);
            }
            int temMin = Mathf.FloorToInt(restante / 60);
            int temSeg = Mathf.FloorToInt(restante % 60);
            Tiempo.text = string.Format("{00:00}:{01:00}", temMin, temSeg);
            timer2 = (int)(30-restante) + 1;
            WinTimer.tomer = timer2;
        }
        
    }
    IEnumerator gameover()
    {
        silencio();
        audioSource.PlayOneShot(perder, 0.7F);
        restante = +8;
        yield return new WaitForSeconds(7);
        SceneManager.LoadScene("MainMenu");
        

    }
}
