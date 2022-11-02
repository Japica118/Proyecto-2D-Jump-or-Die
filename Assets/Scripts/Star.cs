using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public StarCounter starCounter;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        starCounter.AddStar();
        Destroy(gameObject);
    }
}
