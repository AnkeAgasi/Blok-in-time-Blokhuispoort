using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
private Vector2 moveDirection = Vector3.zero;
    [SerializeField] float moveSpeed = 15f;
    [SerializeField] float boostSpeed = 25f;
    [SerializeField] float jumpVelocity = 20f;
    [SerializeField] float sBoostSpeed = 15f;
    

    private Rigidbody2D rigidbody2d;
    private AudioSource _audioSource;
    public bool isGrounded = false;
  

     SpriteRenderer spriteRenderer;
     bool hasKey;

 void Awake() {
rigidbody2d = transform.GetComponent<Rigidbody2D>();

}
   
   private void Start() {
       spriteRenderer = GetComponent<SpriteRenderer> ();    
       _audioSource = GetComponent<AudioSource>();
   }
       void Update()
    {
        float moveAmount = Input.GetAxis ("Horizontal") * moveSpeed * Time.deltaTime;
        transform.Translate(moveAmount, 0, 0);
     


        
        {if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
rigidbody2d.velocity = Vector2.up * jumpVelocity;

        }
        
if (isGrounded) {
_audioSource.Play();
}

    }

    
     void OnTriggerEnter2D(Collider2D other) {
               
if (other.tag == "Booster") 
{
jumpVelocity = boostSpeed;
}   
if (other.tag == "SBoost") {
jumpVelocity = sBoostSpeed;    
}

    }
    
void OnTriggerExit2D(Collider2D other) {
               
if (other.tag == "Booster") 
{
jumpVelocity = 10f;
}
if (other.tag == "SBoost") {
jumpVelocity = 10f;   
}
    
}
}
