using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
   public GameObject title;
   public GameObject mainButtons;
   public GameObject optionsMenu;
   public GameObject canvas;

   public void OpenOptions()
   {
       title.SetActive(false);
       mainButtons.SetActive(false);
       optionsMenu.SetActive(true);
   }

   public void ToggleCanvasGroupActive()
   {
       canvas.gameObject.SetActive(!canvas.gameObject.activeSelf);
   }

   public void LoadLevel1()
   {
       SceneManager.LoadScene("Platforms");
   }

   public void LoadMenuPrincipal()
   {
       SceneManager.LoadScene("MainMenu");
   }
}
