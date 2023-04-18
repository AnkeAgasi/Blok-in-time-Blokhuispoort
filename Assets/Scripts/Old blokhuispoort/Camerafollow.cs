using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
      public Transform Player;
 
 
     void Update ()
     {
          transform.position = new Vector3(Player.position.x, 1.5f, -30);
     }
 }
