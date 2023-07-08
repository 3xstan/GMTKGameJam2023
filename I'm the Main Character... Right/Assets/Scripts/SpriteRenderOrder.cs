using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRenderOrder : MonoBehaviour
{
    // Whenever it's updated
    public void OnUpdate()
    {
        SpriteRenderer[] renderers = FindObjectsOfType<SpriteRenderer>();

        foreach(SpriteRenderer renderer in renderers)
        {
            renderer.sortingOrder = (int)(renderer.transform.position.y * -100);
        }
    }
}
