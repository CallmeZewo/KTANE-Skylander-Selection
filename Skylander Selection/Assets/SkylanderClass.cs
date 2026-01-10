using UnityEngine;
using static Enums;

public class SkylanderClass
{
    public Sprite Sprite;
    public ElementEnum Element;
    public AudioClip Catchphrase;

    public SkylanderClass(Sprite sprite, ElementEnum elementEnum, AudioClip catchphrase)
    {
        Sprite = sprite;
        Element = elementEnum;
        Catchphrase = catchphrase;
    }
}