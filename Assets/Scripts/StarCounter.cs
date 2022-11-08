using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StarCounter : MonoBehaviour
{
    public int numberofStars;
    public Text numberofstarsText;
    
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


    
}
