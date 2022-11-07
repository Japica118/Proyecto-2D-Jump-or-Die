using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour
{
    public Animator animator;
    private SFXManager sfxManager;

    private void Awake()
    {
        sfxManager = GameObject.Find("SFXManager").GetComponent<SFXManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            sfxManager.BombaSound();
            Debug.Log("Ha explotado");
            animator.SetBool("Bomba", true);
            Destroy(this.gameObject,.5f);
            GameManager.Instance.PerderVida();
        }
        /*else
        {
            sfxManager.DeathSound();
        }*/

    }
     
}
