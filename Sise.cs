using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Sise : MonoBehaviour
{
    [SerializeField] Transform sise2;
    [SerializeField] TextMeshProUGUI canYazisi, bitisYazisi;
    [SerializeField] int can;
    [SerializeField] AudioSource siseDusurme;

    void Update()
    {
        canYazisi.text = "Can : " + can.ToString();
        if(can == 0)
        {
            bitisYazisi.text = "Oyun Bitti\nTekrar Baslamak İcin Bir Tusa Basin";
            Time.timeScale = 0;
            if(Input.anyKeyDown)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1;
            }
        }
    }
    void OnCollisionEnter(Collision temas)
    {
        float xPozisyonu = Random.Range(-10f, 11f);
        if(temas.gameObject.tag == "Zemin")
        {
            sise2.position = new Vector3(xPozisyonu, 6f, 0f);
            can--;
            siseDusurme.Play();
        }
    }
}
