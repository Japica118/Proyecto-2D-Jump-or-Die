using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Image [] vida;
    public int vidasRestantes;
    
    void Awake()
    {
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
        if(vidasRestantes==0)
        {
            Debug.Log("Una vida menos");
        }
    }

    void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.Return))
        PerderVida();*/
    }

    
}
