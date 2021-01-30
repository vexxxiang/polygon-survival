using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BlockInfo : MonoBehaviour
{
    public int Id ;
    public string Nazwa = "none";
    public Sprite Ikona;
    public TypItemu typItemu;
    public enum TypItemu
    {
        None,
        Jedzenie,
        Surowiec,
        Blok,

    }
}
