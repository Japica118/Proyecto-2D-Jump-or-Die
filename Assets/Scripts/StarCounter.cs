using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StarCounter : MonoBehaviour
{
    public int numberofStars;
    public Text numberofstarsText;
    public GameObject canvas;
    private SFXManager sfxManager;
    private BGMManager bgmManager;
    //public GameObject [] stars;
    // Start is called before the first frame update
    void Awake()
    {
        sfxManager = GameObject.Find("SFXManager").GetComponent<SFXManager>();
        bgmManager = GameObject.Find("BGMManager").GetComponent<BGMManager>();
        canvas.GetComponent<GameObject>();
    }
    
    void Start()
    {
        numberofStars = 0;
        numberofstarsText.text = numberofStars.ToString();

        //stars = numberofStars;
         
    }

    // Update is called once per frame
    public void AddStar()
    {
        numberofStars++;
        numberofstarsText.text =  numberofStars.ToString();
    }

    public void EstrellasTotales()
    {
        if(numberofStars == 8)
        {
            bgmManager.StopBGM();
            canvas.SetActive(true);
            Destroy(GameObject.FindWithTag("Player"));
            Debug.Log("He ganado");
        }
    }

    
}
