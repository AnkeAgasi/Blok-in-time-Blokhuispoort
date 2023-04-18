using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Potionscript : MonoBehaviour
{
public bool hasPPotion;
public bool hasGPotion;
public bool hasBPotion;
public bool hasYPotion;
public bool hasRoPotion;
public bool hasOPotion;
public bool hasRPotion;
public bool FullPurple;
public bool FullOrange;
public bool FullGreen;



    SpriteRenderer spriteRenderer;
 [SerializeField] float destroyDelay = 0.5f;

 public Sprite newSprite;

        void Start()
    {
           spriteRenderer = GetComponent<SpriteRenderer> ();   
           spriteRenderer = gameObject.GetComponent<SpriteRenderer> ();   
           FullGreen = false;
           FullOrange = false;
           FullPurple = false; 
    }


public void Update() {    
}

    void OnTriggerEnter2D(Collider2D other)
    {
      if (other.tag == "BPotion") 
     {
      Debug.Log("BPotion picked up");
      hasBPotion = true;}

      if (other.tag == "YPotion") 
     {
      Debug.Log("YPotion picked up");
      hasYPotion = true;}

      if (other.tag == "RPotion") 
     {
      Debug.Log("RPotion picked up");
      hasRPotion = true;}

      if (other.tag == "RoPotion") 
     {
      Debug.Log("RoPotion picked up");
      hasRoPotion = true;}

      if (other.tag == "GPotion") 
     {
      Debug.Log("GPotion picked up");
      hasGPotion = true;}

      if (other.tag == "PPotion") 
     {
      Debug.Log("PPotion picked up");
      hasPPotion = true;}

      if (other.tag == "OPotion") 
     {
      Debug.Log("OPotion picked up");
      hasOPotion = true;}




if (other.tag == "BPotion" || other.tag == "PPotion" || other.tag == "RoPotion" || other.tag == "YPotion" || other.tag == "GPotion" || other.tag == "OPotion" || other.tag == "RPotion"){
 Destroy(other.gameObject, destroyDelay);
}


if (other.tag == "Empty" && hasBPotion && hasYPotion )
{
other.GetComponent<SpriteRenderer>().color = new Color32 (0,255,0,255);
hasBPotion = false;
hasYPotion = false;
gameObject.tag = "NoLongerEmpty";
FullGreen = true;
}
if (other.tag == "Empty" && hasRPotion && hasYPotion )
{
other.GetComponent<SpriteRenderer>().color = new Color32(206,115,54,255);
hasRPotion = false;
hasYPotion = false;
gameObject.tag = "NoLongerEmpty";
FullOrange = true;
}
if (other.tag == "Empty" && hasRPotion && hasBPotion )
{
other.GetComponent<SpriteRenderer>().color = new Color32(120,120,247,255);
hasRPotion = false;
hasBPotion = false;
gameObject.tag = "NoLongerEmpty";
FullPurple = true;
}
if (other.tag == "Empty" && hasRPotion && hasRoPotion )
{
other.GetComponent<SpriteRenderer>().color = new Color32(179,170,92,255);
hasRPotion = false;
hasRoPotion = false;
gameObject.tag = "NoLongerEmpty";
}
if (other.tag == "Empty" && hasRPotion && hasGPotion )
{
other.GetComponent<SpriteRenderer>().color = new Color32(179,170,92,255);
hasRPotion = false;
hasGPotion = false;
gameObject.tag = "NoLongerEmpty";
}
if (other.tag == "Empty" && hasRPotion && hasPPotion )
{
other.GetComponent<SpriteRenderer>().color = new Color32(179,170,92,255);
hasRPotion = false;
hasPPotion = false;
gameObject.tag = "NoLongerEmpty";
}
if (other.tag == "Empty" && hasRPotion && hasOPotion )
{
other.GetComponent<SpriteRenderer>().color = new Color32(179,170,92,255);
hasRPotion = false;
hasOPotion = false;
gameObject.tag = "NoLongerEmpty";
}
if (other.tag == "Empty" && hasBPotion && hasRoPotion )
{
other.GetComponent<SpriteRenderer>().color = new Color32(179,170,92,255);
hasBPotion = false;
hasRoPotion = false;
gameObject.tag = "NoLongerEmpty";
}
if (other.tag == "Empty" && hasBPotion && hasGPotion )
{
other.GetComponent<SpriteRenderer>().color = new Color32(179,170,92,255);
hasBPotion = false;
hasGPotion = false;
gameObject.tag = "NoLongerEmpty";
}
if (other.tag == "Empty" && hasBPotion && hasPPotion )
{
other.GetComponent<SpriteRenderer>().color = new Color32(179,170,92,255);
hasBPotion = false;
hasPPotion = false;
gameObject.tag = "NoLongerEmpty";
}
if (other.tag == "Empty" && hasBPotion && hasOPotion )
{
other.GetComponent<SpriteRenderer>().color = new Color32(179,170,92,255);
hasBPotion = false;
hasOPotion = false;
gameObject.tag = "NoLongerEmpty";
}
if (other.tag == "Empty" && hasRoPotion && hasYPotion )
{
other.GetComponent<SpriteRenderer>().color = new Color32(179,170,92,255);
hasRoPotion = false;
hasYPotion = false;
gameObject.tag = "NoLongerEmpty";
}
if (other.tag == "Empty" && hasRoPotion && hasGPotion )
{
other.GetComponent<SpriteRenderer>().color = new Color32(179,170,92,255);
hasRoPotion = false;
hasGPotion = false;
gameObject.tag = "NoLongerEmpty";
}
if (other.tag == "Empty" && hasRoPotion && hasPPotion )
{
other.GetComponent<SpriteRenderer>().color = new Color32(179,170,92,255);
hasRoPotion = false;
hasPPotion = false;
gameObject.tag = "NoLongerEmpty";
}
if (other.tag == "Empty" && hasRoPotion && hasOPotion )
{
other.GetComponent<SpriteRenderer>().color = new Color32(179,170,92,255);
hasRoPotion = false;
hasOPotion = false;
gameObject.tag = "NoLongerEmpty";
}
if (other.tag == "Empty" && hasGPotion && hasYPotion )
{
other.GetComponent<SpriteRenderer>().color = new Color32(179,170,92,255);
hasGPotion = false;
hasYPotion = false;
gameObject.tag = "NoLongerEmpty";
}
if (other.tag == "Empty" && hasPPotion && hasYPotion )
{
other.GetComponent<SpriteRenderer>().color = new Color32(179,170,92,255);
hasPPotion = false;
hasYPotion = false;
gameObject.tag = "NoLongerEmpty";
}
if (other.tag == "Empty" && hasGPotion && hasPPotion )
{
other.GetComponent<SpriteRenderer>().color = new Color32(179,170,92,255);
hasGPotion = false;
hasPPotion = false;
gameObject.tag = "NoLongerEmpty";
}
if (other.tag == "Empty" && hasGPotion && hasOPotion )
{
other.GetComponent<SpriteRenderer>().color = new Color32(179,170,92,255);
hasGPotion = false;
hasOPotion = false;
gameObject.tag = "NoLongerEmpty";
}
if (other.tag == "Empty" && hasOPotion && hasPPotion )
{
other.GetComponent<SpriteRenderer>().color = new Color32(179,170,92,255);
hasPPotion = false;
hasOPotion = false;
gameObject.tag = "NoLongerEmpty";
}




 




     if (other.tag == "Door" && FullGreen && FullOrange && FullPurple)
     {
     SceneManager.LoadScene("Plottwist");
     }
    }
}

