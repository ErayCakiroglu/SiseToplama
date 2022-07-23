using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KasaHareket : MonoBehaviour
{
    [SerializeField] float hiz; 
    [SerializeField] Transform sise;
    int puan;
    [SerializeField] TextMeshProUGUI puanYazisi;
    [SerializeField] AudioSource siseAlma;
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(-hiz * Time.deltaTime, 0f, 0f);
        }

        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(hiz * Time.deltaTime, 0f, 0f);
        }
        puanYazisi.text = "Skor : " + puan.ToString();
    }

    void OnCollisionEnter(Collision temas)
    {
        float xPozisyonu = Random.Range(-11f, 12f);
        if(temas.gameObject.tag == "Sise")
        {
            sise.position = new Vector3(xPozisyonu, 6f, 0f);
            puan += Random.Range(1, 15);
            siseAlma.Play();
        }
    }
}
