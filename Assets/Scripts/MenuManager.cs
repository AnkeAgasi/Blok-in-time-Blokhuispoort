using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject menu; 

  private void Start() {
  
  }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
menu.gameObject.SetActive(!menu.gameObject.activeSelf);
        }
    }
}
