using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;



public class Pickupkey : MonoBehaviour
{
bool hasKey;
 private AudioSource _audioSource;
    SpriteRenderer spriteRenderer;

    void Start()
    {
           spriteRenderer = GetComponent<SpriteRenderer> ();   
              _audioSource = GetComponent<AudioSource>();
              
    }



    void OnTriggerEnter2D(Collider2D other)
    {
      if (other.tag == "Key") 
     {
           Debug.Log("Key picked up");
      hasKey = true;

     }

     //void OnTriggerExit2D(Collider2D other){

        
    // }



     if (other.tag == "Door" && hasKey)
     {
     SceneManager.LoadScene("Old blokhuispoort");
     }
      if (other.tag == "Exit")
      {
         SceneManager.LoadScene("Homescherm");
      }
     

   }
}
