using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
public class Quit: MonoBehaviour {   
    
    public void doExitGame() {
     Application.Quit();
     Debug.Log ("The End is Near");
 }
}   
