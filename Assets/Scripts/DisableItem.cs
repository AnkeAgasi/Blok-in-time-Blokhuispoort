using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableItem : MonoBehaviour
{
     public Renderer rend;
         private AudioSource _audioSource;
    SpriteRenderer spriteRenderer;
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        spriteRenderer = GetComponent<SpriteRenderer> ();    
       _audioSource = GetComponent<AudioSource>();
    }

   private void OnTriggerEnter2D(Collider2D other) {
    rend.enabled = false;   
_audioSource.Play();

   }     
    
}
