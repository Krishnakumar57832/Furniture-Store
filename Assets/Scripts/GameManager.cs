using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<TextureEditor> textureEditor = new();
    public void ButtonClick(int type)
    {
        foreach (var item in textureEditor)
        {
            item.ChangeTexture(type);
        }
    }
}
