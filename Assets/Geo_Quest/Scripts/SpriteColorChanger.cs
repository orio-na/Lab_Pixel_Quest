using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteColorChanger : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    // Define three colors to switch between
    public Color color1 = Color.red;
    public Color color2 = Color.green;
    public Color color3 = Color.blue;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (spriteRenderer == null)
        {
            Debug.LogError("SpriteRenderer not found on this GameObject.");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetColor(color1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetColor(color2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetColor(color3);
        }
    }

    void SetColor(Color color)
    {
        if (spriteRenderer != null)
        {
            spriteRenderer.color = color;
        }
    }
}