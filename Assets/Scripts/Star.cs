using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public StarCounter starCounter;
    private SFXManager sfxManager;

    private void Awake()
    {
        sfxManager = GameObject.Find("SFXManager").GetComponent<SFXManager>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        starCounter.AddStar();
        Destroy(gameObject);

        if(collision.gameObject.CompareTag("Player"))
        {
            sfxManager.StarSound();
            Debug.Log("Tengo estrellas");
            Destroy(this.gameObject,.5f);
        }
    }
}
