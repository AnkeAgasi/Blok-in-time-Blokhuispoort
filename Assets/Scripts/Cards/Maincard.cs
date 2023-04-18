using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maincard : MonoBehaviour
{
    GameObject Gamecontroller;
    SpriteRenderer spriteRenderer;
    public Sprite[] faces;
    public Sprite back;
    public int faceindex;
    public bool matched = false;
    private AudioSource _audioSource;
    
    public void OnMouseDown()
    {
        _audioSource.Play();

        if (matched == false)
        {
            if (spriteRenderer.sprite == back)
            {
                if (Gamecontroller.GetComponent<Gamecontroller>().TwoCardsUp() == false)
                {
                    spriteRenderer.sprite = faces[faceindex];
                    Gamecontroller.GetComponent<Gamecontroller>().AddVisibleFace(faceindex);
                    matched = Gamecontroller.GetComponent<Gamecontroller>().CheckMatch();
                }
            }
            else
            {
                spriteRenderer.sprite = back;
                Gamecontroller.GetComponent<Gamecontroller>().RemoveVisibleFace(faceindex);
            }
        }
    }

    public void Awake()
    {
        Gamecontroller = GameObject.Find("Gamecontroller");
        spriteRenderer = GetComponent<SpriteRenderer>();
        _audioSource = GetComponent<AudioSource>();
    }
}
