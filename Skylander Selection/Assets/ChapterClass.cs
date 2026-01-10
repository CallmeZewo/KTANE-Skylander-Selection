using UnityEngine;
using static Enums;
public class ChapterClass
{
    public Sprite Sprite;
    public ElementEnum[] Elements;
    public ChapterClass(Sprite sprite, int index)
    {
        Sprite = sprite;

        switch (index)
        {
            case 0:
                Elements = new ElementEnum[] { ElementEnum.Magic, ElementEnum.Tech, ElementEnum.Water };
                break;
            case 1:
                Elements = new ElementEnum[] { ElementEnum.Life, ElementEnum.Tech, ElementEnum.Water };
                break;
            case 2:
                Elements = new ElementEnum[] { ElementEnum.Earth, ElementEnum.Undead };
                break;
            case 3:
                Elements = new ElementEnum[] { ElementEnum.Air, ElementEnum.Life};
                break;
            case 4:
                Elements = new ElementEnum[] { ElementEnum.Fire };
                break;
            case 5:
                Elements = new ElementEnum[] { ElementEnum.Magic, ElementEnum.Water };
                break;
            case 6:
                Elements = new ElementEnum[] { ElementEnum.Water };
                break;
            case 7:
                Elements = new ElementEnum[] { ElementEnum.Earth, ElementEnum.Undead };
                break;
            case 8:
                Elements = new ElementEnum[] { ElementEnum.Life };
                break;
            case 9:
                Elements = new ElementEnum[] { ElementEnum.Magic };
                break;
            case 10:
                Elements = new ElementEnum[] { ElementEnum.Earth };
                break;
            case 11:
                Elements = new ElementEnum[] { ElementEnum.Fire, ElementEnum.Life };
                break;
            case 12:
                Elements = new ElementEnum[] { ElementEnum.Air, ElementEnum.Fire };
                break;
            case 13:
                Elements = new ElementEnum[] { ElementEnum.Undead };
                break;
            case 14:
                Elements = new ElementEnum[] { ElementEnum.Undead };
                break;
            case 15:
                Elements = new ElementEnum[] { ElementEnum.Earth, ElementEnum.Tech };
                break;
            case 16:
                Elements = new ElementEnum[] { ElementEnum.Air };
                break;
            case 17:
                Elements = new ElementEnum[] { ElementEnum.Tech };
                break;
            case 18:
                Elements = new ElementEnum[] { ElementEnum.Fire };
                break;
            case 19:
                Elements = new ElementEnum[] { ElementEnum.Life };
                break;
            case 20:
                Elements = new ElementEnum[] { ElementEnum.Air };
                break;
            case 21:
                Elements = new ElementEnum[] { ElementEnum.Magic };
                break;
        }
    }
}