using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    protected string shapeName;
    protected string color;

    protected Renderer rendererReference;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected void GetMaterialColor()
    {
        rendererReference = GetComponent<Renderer>();
        color = rendererReference.material.name;
        Debug.Log(color);
    }

    protected void GetShapeName()
    {
        shapeName = gameObject.name;
        Debug.Log(gameObject);
    }
}
