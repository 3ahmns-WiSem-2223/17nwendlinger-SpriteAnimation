using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteAnimation : MonoBehaviour
{
    [SerializeField] Sprite[] run;

    void Start()
    {
        Debug.Log("Anzahl Elemente: " + run.Length);
    }
}
