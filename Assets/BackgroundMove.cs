using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    public Material material;
    public float speed = 0.1f;

    private float offset;

    private void Start()
    {
        if (material == null)
        {
            Renderer renderer = GetComponent<Renderer>();
            if (renderer != null)
                material = renderer.material;
        }
    }

    private void Update()
    {
        offset += speed * Time.deltaTime;
        material.mainTextureOffset = new Vector2(offset, offset);
    }
}
