using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private SFXManager sfxManager;
    private BGMManager bgmManager;
    public int numberofStars;
    public Text numberofstarsText;
    public Image [] vida;
    public int vidasRestantes;
    
    public GameObject canvas;
    public GameObject canvasV;

    
    void Awake()
    {
        sfxManager = GameObject.Find("SFXManager").GetComponent<SFXManager>();
        bgmManager = GameObject.Find("BGMManager").GetComponent<BGMManager>();
        canvas.GetComponent<GameObject>();
        canvasV.GetComponent<GameObject>();
        
        //Si ya hay una instancia y no soy yo, me destruyo. 
        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

        DontDestroyOnLoad(this);
    }

    public void PerderVida()
    {
        vidasRestantes--;
        vida[vidasRestantes].enabled = false;
        if(vidasRestantes == 0)
        {
            bgmManager.StopBGM();
            sfxManager.DeathSound();
            canvas.SetActive(true);
            Destroy(GameObject.FindWithTag("Player"));
            Debug.Log("Una vida menos");
        }
    }

   public void EstrellasTotales()
    {
        numberofStars++;
        numberofstarsText.text =  numberofStars.ToString();
        sfxManager.StarSound();
        if(numberofStars == 8)
        {
            bgmManager.StopBGM();
            canvasV.SetActive(true);
            Destroy(GameObject.FindWithTag("Player"));
            Debug.Log("He ganado");
        }
    }


    
       

    void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.Return))
        PerderVida();*/
    }

    
}
