using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private SFXManager sfxManager;
    private BGMManager bgmManager;
    private int stars;

    public Image [] vida;
    public int vidasRestantes;
    
    public GameObject canvas;

    
    void Awake()
    {
        sfxManager = GameObject.Find("SFXManager").GetComponent<SFXManager>();
        bgmManager = GameObject.Find("BGMManager").GetComponent<BGMManager>();
        canvas.GetComponent<GameObject>();
        
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
            canvas.SetActive(true);
            Destroy(GameObject.FindWithTag("Player"));
            Debug.Log("Una vida menos");
        }
    }








    void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.Return))
        PerderVida();*/
    }

    
}
