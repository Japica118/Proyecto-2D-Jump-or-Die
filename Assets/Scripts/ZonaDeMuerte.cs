using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZonaDeMuerte : MonoBehaviour
{
    private SFXManager sfxManager;
    private BGMManager bgmManager;
    public GameObject canvas;
    // Start is called before the first frame update
    void Awake()
    {
        sfxManager = GameObject.Find("SFXManager").GetComponent<SFXManager>();
        bgmManager = GameObject.Find("BGMManager").GetComponent<BGMManager>();
        canvas.GetComponent<GameObject>();
        //sfxManager = GameObject.Find("SFXManager").GetComponent<SFXManager>();
        //bgmManager = GameObject.Find("BGMManager").GetComponent<BGMManager>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            bgmManager.StopBGM();
            sfxManager.DeathSound();
            canvas.SetActive(true);
            Destroy(collision.gameObject);            
            Debug.Log("Has perdido");
        }

    }


}